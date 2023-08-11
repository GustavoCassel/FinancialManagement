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

    public async Task GenerateRelatory()
    {
        /*int rowIndex = 0;
        foreach (DailyEntries accoutingEntries in _accoutingEntries)
        {
            rowIndex++;

            DailyEntries? financialEntries = _financialEntries.Find(
                entry => entry.Date == accoutingEntries.Date)
                ?? throw new Exception();

            await _excel.WriteValueToWorksheet(rowIndex);

            string[] row = new string[4]
            {
                dailyAcc.Date.ToShortDateString(),
                $"{Math.Abs(difCredit):C2}",
                $"{Math.Abs(difDebit):C2}",
                $"{Math.Abs(difCredit - difDebit):C2}"
            };

        }*/
    }
}