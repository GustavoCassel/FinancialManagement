using AppUI.EntryManagement;
using AppUI.ExcelApplication;

namespace AppUI.Reports;

public sealed class EntriesReport
{
    private readonly Excel _excel;
    private readonly string _fileName;
    private readonly List<DailyEntries> _accoutingEntries;
    private readonly List<DailyEntries> _financialEntries;

    public EntriesReport(string fileName, List<DailyEntries> accoutingEntries, List<DailyEntries> financialEntries)
    {
        _excel = new(fileName);
        _fileName = fileName;
        _accoutingEntries = accoutingEntries;
        _financialEntries = financialEntries;
    }

    public void GenerateRelatory()
    {
        throw new NotImplementedException();
    }
}