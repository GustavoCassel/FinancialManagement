using AppUI.EntryManagement;

namespace AppUI.ExcelApplication;

public interface IExcelReader
{
    public List<DailyEntries> GetEntries();

    public Entry? GetEntry(int row, DateTime date);

    public string? GetInvoiceCode(string text);
}