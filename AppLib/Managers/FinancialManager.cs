using AppLib.EntryManagement;
using AppLib.ExcelApplication;

namespace AppLib.Managers;

public sealed class FinancialManager : IExcelReader
{
    private readonly Excel _excelReader;
    public FinancialManager(Excel excelReader)
    {
        _excelReader = excelReader;
    }

    public List<DailyEntries> GetEntries()
    {
        List<DailyEntries> entries = new();
        int rowsCount = _excelReader.GetNumberOfRows();
        const string SupplierCode = "2010101001";
        const string Multiple = "Múl";

        for (int rowIndex = 1; rowIndex < rowsCount; rowIndex++)
        {
            string? balanceTypeCode = _excelReader.GetTextFromWorksheet(rowIndex, "T");
            if (!string.IsNullOrWhiteSpace(balanceTypeCode))
                if (balanceTypeCode != SupplierCode)
                    break;

            string? dateRaw = _excelReader.GetTextFromWorksheet(rowIndex, "A");
            if (string.IsNullOrWhiteSpace(dateRaw))
                continue;

            if (!DateTime.TryParse(dateRaw, out DateTime date))
                continue;

            string? multiple = _excelReader.GetTextFromWorksheet(rowIndex, "M");
            if (!string.IsNullOrWhiteSpace(multiple))
                if (multiple == Multiple)
                    continue;

            DailyEntries? dailyEntries = entries.Find(entry => entry.Date == date);
            if (dailyEntries == null)
            {
                dailyEntries = new DailyEntries(date);
                entries.Add(dailyEntries);
            }

            Entry? entry = GetEntry(rowIndex, date);
            if (entry != null)
                dailyEntries.AddEntry(entry);
        }

        return entries.OrderBy(entry => entry.Date).ToList();
    }

    public Entry? GetEntry(int row, DateTime date)
    {
        string? invoiceCodeRaw = _excelReader.GetTextFromWorksheet(row, "R");
        if (string.IsNullOrWhiteSpace(invoiceCodeRaw))
            return null;

        string? invoiceCode = GetInvoiceCode(invoiceCodeRaw);
        if (string.IsNullOrWhiteSpace(invoiceCode))
            return null;

        _excelReader.GetPaymentAndValue(row, "BK", "CA", out Payment payment, out decimal value);

        string description = GetDescription(row);

        return new Entry(invoiceCode, date, description, payment, value);
    }

    public string? GetInvoiceCode(string text)
    {
        const char Slash = '/';
        const int MaxSplitCount = 2;

        if (!text.Contains(Slash))
            if (text.All(char.IsNumber))
                return text;

        string[] split = text.Split(Slash);
        if (split.Length > MaxSplitCount)
            return null;

        if (split[0].All(char.IsNumber))
            return split[0];

        return null;
    }

    private string GetDescription(int row)
    {
        string? text = null;
        while (string.IsNullOrWhiteSpace(text))
        {
            text = _excelReader.GetTextFromWorksheet(row, "Y");
            row--;
        }

        return text;
    }
}