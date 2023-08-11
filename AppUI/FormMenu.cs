using AppUI.EntryManagement;
using AppUI.ExcelApplication;
using AppUI.Managers;

namespace AppUI;

public partial class FormMenu : Form
{
    private readonly string _accountingFilePath;
    private readonly string _financialFilePath;
    private List<DailyEntries> _accoutingEntries = new();
    private List<DailyEntries> _financialEntries = new();

    public FormMenu(string accountingFilePath, string financialFilePath)
    {
        InitializeComponent();
        _accountingFilePath = accountingFilePath;
        _financialFilePath = financialFilePath;
    }

    private void FormMenu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) { Close(); Dispose(); }
    }

    private async Task<List<DailyEntries>> GetAccoutingEntries()
    {
        return await Task.Run(delegate
        {
            using Excel excel = new(_accountingFilePath);
            IExcelReader manager = new AccoutingManager(excel, this);

            return manager.GetEntries();
        });
    }

    private async Task<List<DailyEntries>> GetFinancialEntries()
    {
        return await Task.Run(delegate
        {
            using Excel excel = new(_financialFilePath);
            IExcelReader manager = new FinancialManager(excel, this);

            return manager.GetEntries();
        });
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
        ButtonStart.Visible = false;
        GroupBoxLog.Visible = true;

        GroupBoxLog.Text = "Lendo Arquivo Razão Contábil";

        try
        {
            _accoutingEntries = await GetAccoutingEntries();
            if (_accoutingEntries.Count == 0)
                throw new Exception("Não encontrou nenhum lançamento!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao analisar o arquivo!\nErro: {ex.Message}",
                "Razão Contábil!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Dispose();
            return;
        }

        Update();

        GroupBoxLog.Text = "Lendo Arquivo Razão Financeira";
        try
        {
            _financialEntries = await GetFinancialEntries();
            if (_financialEntries.Count == 0)
                throw new Exception("Não encontrou nenhum lançamento!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao analisar o arquivo!\nErro: {ex.Message}",
                "Razão Auxiliar Contas a Pagar!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Dispose();
            return;
        }

        GroupBoxLog.Text = "Comparando Valores";

        try
        {
            MatchValues();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao comparar valores!\nErro: {ex.Message}",
               "Razão Auxiliar Contas a Pagar!", MessageBoxButtons.OK,
               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Dispose();
        }



    }

    private void FormatListView()
    {
        ChangeLog(true);

        const string FormattedZeroString = "R$ 0,00";
        foreach (ListViewItem item in ListViewMatch.Items)
        {
            item.UseItemStyleForSubItems = false;

            if (item.SubItems[3].Text == FormattedZeroString)
                item.SubItems[3].BackColor = Color.LightGreen;
            else
            {
                item.SubItems[3].BackColor = Color.OrangeRed;
                ChangeLog(false);
            }
        }

        ListViewMatch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        ListViewMatch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private void MatchValues()
    {
        if (_financialEntries.Count != _accoutingEntries.Count)
            throw new Exception("Não encontrou mesma quantidade de dias!");

        if (!_accoutingEntries.All(entryAcc =>
            _financialEntries.Find(entryFin => entryFin.Date == entryAcc.Date) != null))
            throw new Exception("Não contém os mesmos dias!");

        foreach (DailyEntries dailyFin in _financialEntries)
        {
            decimal totalFinCredit = dailyFin.GetTotalByPayment(Payment.Credit);
            decimal totalFinDebit = dailyFin.GetTotalByPayment(Payment.Debit);

            DailyEntries? dailyAcc = _accoutingEntries.Find(entry => entry.Date == dailyFin.Date) ?? throw new Exception("Não achou data");

            decimal totalAccCredit = dailyAcc.GetTotalByPayment(Payment.Credit);
            decimal totalAccDebit = dailyAcc.GetTotalByPayment(Payment.Debit);

            decimal difCredit = totalFinCredit - totalAccCredit;
            decimal difDebit = totalFinDebit - totalAccDebit;

            string[] row = new string[4]
            {
                dailyAcc.Date.ToShortDateString(),
                $"{Math.Abs(difCredit):C2}",
                $"{Math.Abs(difDebit):C2}",
                $"{Math.Abs(difCredit - difDebit):C2}"
            };

            ListViewItem item = new(row)
            {
                Tag = dailyAcc.Date
            };

            ListViewMatch.Items.Add(item);
        }

        FormatListView();
    }

    private void ListViewMatch_ItemActivate(object sender, EventArgs e)
    {
        //string dateRaw = ListViewMatch.SelectedItems[0].Text;
        //if (!DateTime.TryParse(dateRaw, out DateTime date))
        //{
        //    MessageBox.Show($"Erro ao obter data da lista!",
        //       "Erro Desconhecido!", MessageBoxButtons.OK,
        //       MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        //    return;
        //}

        DateTime date = (DateTime)ListViewMatch.SelectedItems[0].Tag;

        DailyEntries? accoutingEntries = _accoutingEntries.Find(entry => entry.Date == date);
        DailyEntries? financialEntries = _financialEntries.Find(entry => entry.Date == date);

        if (accoutingEntries == null || financialEntries == null)
        {
            MessageBox.Show($"Erro ao encontrar entradas!",
               "Erro Desconhecido!", MessageBoxButtons.OK,
               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return;
        }

        Hide();
        _ = new FormDayDetail(date, accoutingEntries, financialEntries).ShowDialog(this);
        Show();
    }

    private void ChangeLog(bool success)
    {
        GroupBoxLog.Visible = false;

        LabelStatus.Visible = true;
        LabelLog.Visible = true;
        LabelLog.BackColor = success ? Color.Lime : Color.Red;
        LabelLog.Text = success ? "OK" : "ERRO";
    }

    public void UpdateLineLogger(int totalRows, int currentRow)
    {
        LabelRowLine.Text = $"Linha: {currentRow} de: {totalRows}";
    }

    public void AppendLogMessage(Entry entry)
    {
        string message = $"Dia: {entry.Date.Day:00}-{entry.Date.Month:00} Nota: {entry.InvoiceCode} Tipo: {entry.Payment} Valor: {entry.Value:C2}";
        ListViewLog.Items.Add(new ListViewItem(message)).EnsureVisible();
    }

    private void GroupBoxLog_Resize(object sender, EventArgs e)
    {
        ListViewLog.Columns[0].Width = ListViewLog.Width - 20;
    }
}