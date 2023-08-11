namespace AppUI;

public partial class FormHelp : Form
{
    public FormHelp()
    {
        InitializeComponent();
    }

    private void FormHelp_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) { Close(); Dispose(); }
    }
}