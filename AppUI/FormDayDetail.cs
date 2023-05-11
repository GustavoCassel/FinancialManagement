using AppLib.EntryManagement;
using AppUI.Util;

namespace AppUI;

public partial class FormDayDetail : Form
{
    public FormDayDetail(DateTime date, DailyEntries accoutingEntries, DailyEntries financialEntries)
    {
        InitializeComponent();
        ListViewAccounting.ListViewItemSorter = new ListViewColumnSorter(ListViewAccounting);
        ListViewFinancial.ListViewItemSorter = new ListViewColumnSorter(ListViewFinancial);

        Text = $"Resumo dia: {date.ToShortDateString()}";

        UpdateDisplay(accoutingEntries, financialEntries);
    }

    private void FormDayDetail_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) { Close(); Dispose(); }
    }

    private void ListViewAccounting_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        ListViewColumnSorter? sorter = (ListViewColumnSorter?)ListViewAccounting.ListViewItemSorter;
        if (sorter == null)
            return;

        sorter.SortListView(e);
    }

    private void ListViewFinancial_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        ListViewColumnSorter? sorter = (ListViewColumnSorter?)ListViewFinancial.ListViewItemSorter;
        if (sorter == null)
            return;

        sorter.SortListView(e);
    }

    private void UpdateDisplay(DailyEntries accoutingEntries, DailyEntries financialEntries)
    {
        List<MergedEntry> mergedAcc = Merge(accoutingEntries);
        LabelInfoAccouting.Text = $"Total de Lançamentos: {mergedAcc.Count}";
        AddToListViewEntries(ListViewAccounting, mergedAcc);

        List<MergedEntry> mergedFin = Merge(financialEntries);
        LabelInfoFinancial.Text = $"Total de Lançamentos: {mergedFin.Count}";
        AddToListViewEntries(ListViewFinancial, mergedFin);

        CompareAndPaintDifferent();
    }

    private void CompareAndPaintDifferent()
    {
        foreach (ListViewItem accItem in ListViewAccounting.Items)
        {
            string? accCode = accItem.Text;
            if (accCode == null)
                continue;

            ListViewItem? finItem = GetCorrespondingItem(accCode);
            if (finItem == null)
                continue;

            string? accValue = accItem.SubItems[3].Text;
            if (accValue == null)
                continue;

            string? finValue = finItem.SubItems[3].Text;
            if (finValue == null)
                continue;

            if (accValue != finValue)
            {
                accItem.BackColor = Color.LightPink;
                finItem.BackColor = Color.LightPink;
            }
        }
    }

    private ListViewItem? GetCorrespondingItem(string invoiceCode)
    {
        foreach (ListViewItem item in ListViewFinancial.Items)
        {
            string? code = item.Text;
            if (code == null)
                continue;

            if (code == invoiceCode)
                return item;
        }

        return null;
    }

    private static void AddToListViewEntries(ListView listView, List<MergedEntry> entries)
    {
        foreach (MergedEntry merged in entries)
        {
            string[] row = new string[5]
            {
                merged.InvoiceCode,
                $"{merged.TotalCredit:C2}",
                $"{merged.TotalDebit:C2}",
                $"{merged.Difference:C2}",
                merged.Description
            };

            listView.Items.Add(new ListViewItem(row));
        }

        listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    public static List<MergedEntry> Merge(DailyEntries dailyEntries)
    {
        List<MergedEntry> mergedEntries = new();

        foreach (Entry entry in dailyEntries.Entries)
        {
            MergedEntry? mergedEntry = mergedEntries.Find(merged => merged.InvoiceCode == entry.InvoiceCode);

            if (mergedEntry == null)
            {
                mergedEntry = new(entry);

                mergedEntries.Add(mergedEntry);
            }

            mergedEntry.AddPayment(entry.Payment, entry.Value);
        }

        return mergedEntries.OrderBy(entry => entry.InvoiceCode).ToList();
    }
}