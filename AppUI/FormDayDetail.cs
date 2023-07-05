using AppUI.EntryManagement;
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
        FindMissingItems(ListViewAccounting, ListViewFinancial);

        FindMissingItems(ListViewFinancial, ListViewAccounting);

        bool isAccountingWithMoreEntries = ListViewAccounting.Items.Count > ListViewFinancial.Items.Count;

        ListView viewWithMoreEntries = isAccountingWithMoreEntries
            ? ListViewAccounting : ListViewFinancial;

        ListView viewWithLessEntries = isAccountingWithMoreEntries
            ? ListViewFinancial : ListViewAccounting;

        foreach (ListViewItem moreItem in viewWithMoreEntries.Items)
        {
            ListViewItem? lessItem = viewWithLessEntries.Items[moreItem.Text];
            if (lessItem == null)
                continue;

            string moreValue = moreItem.SubItems[3].Text;

            string lessValue = lessItem.SubItems[3].Text;

            if (moreValue != lessValue)
            {
                moreItem.BackColor = Color.LightPink;
                lessItem.BackColor = Color.LightPink;
            }
        }
    }

    private static void FindMissingItems(ListView from, ListView to)
    {
        foreach (ListViewItem fromItem in from.Items)
        {
            ListViewItem? toItem = to.Items[fromItem.Text];
            if (toItem == null)
            {
                // if this item isn't in the other listview
                fromItem.BackColor = Color.Red;
                continue;
            }
        }
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

            ListViewItem item = new(row)
            {
                Name = merged.InvoiceCode
            };

            listView.Items.Add(item);
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

    private void ListViewAccounting_ItemActivate(object sender, EventArgs e)
    {
        ListViewFinancial.SelectedItems.Clear();

        string invoiceCode = ListViewAccounting.SelectedItems[0].Text;

        ListViewItem? item = ListViewFinancial.Items[invoiceCode];
        if (item is null)
            return;

        item.EnsureVisible();
        item.Selected = true;
    }
}