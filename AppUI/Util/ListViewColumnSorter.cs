using System.Collections;

namespace AppUI.Util;

public sealed class ListViewColumnSorter : IComparer
{
    private int _sortColumn;
    private SortOrder _sortOrder;

    private readonly CaseInsensitiveComparer _objectCompare;
    private readonly ListView _listView;

    public ListViewColumnSorter(ListView listView)
    {
        _sortColumn = 0;
        _sortOrder = SortOrder.None;
        _listView = listView;
        _objectCompare = new CaseInsensitiveComparer();
    }
    public int Compare(object? x, object? y)
    {
        if (x == null)
            throw new ArgumentNullException(nameof(x));

        if (y == null)
            throw new ArgumentNullException(nameof(y));

        int compareResult;
        ListViewItem listviewX, listviewY;

        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;

        compareResult = _objectCompare.Compare(listviewX.SubItems[_sortColumn].Text, listviewY.SubItems[_sortColumn].Text);

        switch (_sortOrder)
        {
            case SortOrder.Ascending:
                return compareResult;

            case SortOrder.Descending:
                return -compareResult;

            case SortOrder.None:
            default:
                return 0;
        }
    }

    public void SortListView(ColumnClickEventArgs columnClickEventArgs)
    {
        if (columnClickEventArgs.Column == _sortColumn)
        {
            _sortOrder = _sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
        }
        else
        {
            _sortColumn = columnClickEventArgs.Column;
            _sortOrder = SortOrder.Ascending;
        }

        _listView.Sort();
    }
}