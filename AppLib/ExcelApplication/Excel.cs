using AppLib.EntryManagement;
using AppLib.Exceptions;
using Microsoft.Office.Interop.Excel;

namespace AppLib.ExcelApplication;

public sealed class Excel : IDisposable
{
    private readonly Application _application;
    private readonly Workbook _workbook;
    private readonly Worksheet _worksheet;

    public Excel(string fileName)
    {
        _application = new()
        {
            Interactive = false
        };

        if (_application == null)
            throw new ExcelNotInstalledException();

        _workbook = _application.Workbooks.Open(
            Filename: fileName,
            UpdateLinks: false,
            ReadOnly: true
        );

        if (_workbook.Worksheets.Count != 1)
            throw new MoreThanOneWorksheetException();

        _worksheet = _workbook.Worksheets[1];
    }

    public void Dispose()
    {
        foreach (Workbook workbook in _application.Workbooks)
        {
            workbook.Close(SaveChanges: false);
        }

        _application.Quit();

        GC.WaitForPendingFinalizers();
    }

    public int GetNumberOfRows()
    {
        return _worksheet.Cells[_worksheet.Rows.Count, "A"].End[XlDirection.xlUp].Row;
    }

    public string? GetTextFromWorksheet(int row, string column)
    {
        dynamic value = _worksheet.Cells[row, column].Value;
        string? text = Convert.ToString(value);
        return text?.Trim();
    }

    public decimal GetValueFromWorksheet(int row, string column)
    {
        string? text = GetTextFromWorksheet(row, column);
        _ = decimal.TryParse(text, out decimal result);
        return result;
    }

    public void GetPaymentAndValue(int row, string columnDebit, string columnCredit, out Payment payment, out decimal value)
    {
        decimal debitValue = GetValueFromWorksheet(row, columnDebit);
        decimal creditValue = GetValueFromWorksheet(row, columnCredit);

        if (debitValue != default)
        {
            payment = Payment.Debit;
            value = debitValue;
        }
        else if (creditValue != default)
        {
            payment = Payment.Credit;
            value = creditValue;
        }
        else
        {
            payment = Payment.None;
            value = decimal.Zero;
        }
    }
}