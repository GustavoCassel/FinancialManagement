using AppUI.EntryManagement;
using AppUI.ExcelApplication;

namespace AppUI.Managers;

public sealed class AccoutingManager : IExcelReader
{
    private readonly Excel _excelReader;
    private readonly FormMenu _formMenu;
    public AccoutingManager(Excel excelReader, FormMenu formMenu)
    {
        _excelReader = excelReader;
        _formMenu = formMenu;
    }

    public List<DailyEntries> GetEntries()
    {
        int rowsCount = _excelReader.GetNumberOfRows();
        Stack<DailyEntries> stack = new();

        for (int rowIndex = 1; rowIndex < rowsCount; rowIndex++)
        {
            _formMenu.Invoke(delegate
            {
                _formMenu.UpdateLineLogger(rowsCount, rowIndex);
            });

            string? dateOrDashValue = _excelReader.GetTextFromWorksheet(rowIndex, "A");

            if (string.IsNullOrWhiteSpace(dateOrDashValue))
                continue;

            if (!dateOrDashValue.Contains('-'))
                continue;

            if (!(dateOrDashValue.Length == 1 && dateOrDashValue[0] == '-'))
            {
                if (!DateTime.TryParse(dateOrDashValue.Replace('-', ' '), out DateTime date))
                    throw new Exception("Não foi possível converter a data!");

                if (stack.Count == 0)
                {
                    stack.Push(new DailyEntries(date));
                }
                else
                {
                    if (stack.Peek().Date != date)
                        stack.Push(new DailyEntries(date));
                }
            }

            DailyEntries daily = stack.Peek();

            Entry? entry = GetEntry(rowIndex, daily.Date);

            if (entry != null)
            {
                _formMenu.Invoke(delegate
                {
                    _formMenu.AppendLogMessage(entry);
                });
                daily.AddEntry(entry);
            }
        }

        return stack.OrderBy(entry => entry.Date).ToList();
    }

    public Entry? GetEntry(int row, DateTime date)
    {
        string? description = _excelReader.GetTextFromWorksheet(row, "B");
        if (string.IsNullOrWhiteSpace(description))
            return null;

        _excelReader.GetPaymentAndValue(row, "E", "F", out Payment payment, out decimal value);

        string? invoiceCode = GetInvoiceCode(description);
        //if (string.IsNullOrWhiteSpace(invoiceCode))
        //    return null;

        return new Entry(invoiceCode, date, description, payment, value);
    }

    public string? GetInvoiceCode(string text)
    {
        // DEBITO BANC.MULT. 094707/07 HDI SEGUROS S.A.
        // VLR NF NR-211-001-LASER.RS SOLUCOES INDUSTRIAIS LTDA

        string[] split = text.Replace('-', ' ').Split(' ');
        foreach (string value in split)
        {
            if (string.IsNullOrWhiteSpace(value))
                continue;

            if (!char.IsNumber(value[0]))
                continue;

            if (!value.Contains('/'))
                if (value.All(char.IsNumber))
                    return value;
                else
                    continue;

            string[] valueSplitted = value.Split('/');
            if (valueSplitted[0].All(char.IsNumber))
                return valueSplitted[0];
        }

        return null;
    }
}