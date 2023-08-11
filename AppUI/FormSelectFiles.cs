namespace AppUI;

public partial class FormSelectFiles : Form
{
    public string? AccountingFileName { get; private set; }
    public string? FinancialFileName { get; private set; }

    public FormSelectFiles()
    {
        InitializeComponent();
#if DEBUG
        const string AccPath = "C:\\Users\\gustavo.cassel\\Desktop\\Relatorios\\RazaoFinanceira0107_3107.xls";
        AccountingFileName = AccPath;
        TextBoxAccountingPath.Text = AccountingFileName;
        TextBoxAccountingPath.Visible = AccountingFileName != null;

        const string FinPath = "C:\\Users\\gustavo.cassel\\Desktop\\Relatorios\\41172 RAZ AUX CPAGAR  010723 310723.xls";
        FinancialFileName = FinPath;
        TextBoxFinancialPath.Text = FinancialFileName;
        TextBoxFinancialPath.Visible = FinancialFileName != null;
#endif
    }

    #region Events

    private void ButtonFileAccounting_Click(object sender, EventArgs e)
    {
        AccountingFileName = OpenFileDialog.ShowDialog() == DialogResult.Cancel ?
            null : OpenFileDialog.FileName;

        TextBoxAccountingPath.Text = AccountingFileName;
        TextBoxAccountingPath.Visible = AccountingFileName != null;
    }

    private void ButtonFileFinancial_Click(object sender, EventArgs e)
    {
        FinancialFileName = OpenFileDialog.ShowDialog() == DialogResult.Cancel ?
            null : OpenFileDialog.FileName;

        TextBoxFinancialPath.Text = FinancialFileName;
        TextBoxFinancialPath.Visible = FinancialFileName != null;
    }

    private void TextBoxAccountingPath_TextChanged(object sender, EventArgs e)
    {
        AutoReziseTextBox(TextBoxAccountingPath);
    }

    private void TextBoxFinancialPath_TextChanged(object sender, EventArgs e)
    {
        AutoReziseTextBox(TextBoxFinancialPath);
    }

    private void AutoReziseTextBox(TextBox textBox)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            return;

        Size size = TextRenderer.MeasureText(textBox.Text, TextBoxAccountingPath.Font);
        textBox.Width = size.Width;
        textBox.Height = size.Height;
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
        Close();
        Dispose();
    }

    private void FormSelectFiles_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) { Close(); Dispose(); }
    }

    #endregion

    #region Buttons

    private void ButtonContinue_Click(object sender, EventArgs e)
    {
        if (AccountingFileName == null)
        {
            MessageBox.Show("Arquivo Contábil não selecionado!", "Diretório Inválido!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (FinancialFileName == null)
        {
            MessageBox.Show("Arquivo Financeiro não selecionado!", "Diretório Inválido!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        Hide();

        _ = new FormMenu(
            AccountingFileName,
            FinancialFileName)
        .ShowDialog(this);

        Show();
    }

    private void ButtonHelp_Click(object sender, EventArgs e)
    {
        Hide();
        _ = new FormHelp().ShowDialog(this);
        Show();
    }

    #endregion
}