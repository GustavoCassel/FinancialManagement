namespace AppUI;

partial class FormSelectFiles
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectFiles));
        ButtonClose = new Button();
        ButtonFileAccounting = new Button();
        ButtonFileFinancial = new Button();
        OpenFileDialog = new OpenFileDialog();
        label1 = new Label();
        label2 = new Label();
        TextBoxAccountingPath = new TextBox();
        TextBoxFinancialPath = new TextBox();
        ButtonContinue = new Button();
        ButtonHelp = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        splitContainer1 = new SplitContainer();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // ButtonClose
        // 
        ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        ButtonClose.BackColor = Color.CornflowerBlue;
        ButtonClose.Location = new Point(12, 13);
        ButtonClose.Name = "ButtonClose";
        ButtonClose.Size = new Size(100, 40);
        ButtonClose.TabIndex = 7;
        ButtonClose.Text = "Sair";
        ButtonClose.UseVisualStyleBackColor = false;
        ButtonClose.Click += ButtonClose_Click;
        // 
        // ButtonFileAccounting
        // 
        ButtonFileAccounting.BackColor = Color.MediumSlateBlue;
        ButtonFileAccounting.Location = new Point(15, 15);
        ButtonFileAccounting.Margin = new Padding(4);
        ButtonFileAccounting.Name = "ButtonFileAccounting";
        ButtonFileAccounting.Size = new Size(96, 32);
        ButtonFileAccounting.TabIndex = 0;
        ButtonFileAccounting.Text = "Buscar";
        ButtonFileAccounting.UseVisualStyleBackColor = false;
        ButtonFileAccounting.Click += ButtonFileAccounting_Click;
        // 
        // ButtonFileFinancial
        // 
        ButtonFileFinancial.BackColor = Color.MediumSlateBlue;
        ButtonFileFinancial.Location = new Point(15, 15);
        ButtonFileFinancial.Margin = new Padding(4);
        ButtonFileFinancial.Name = "ButtonFileFinancial";
        ButtonFileFinancial.Size = new Size(96, 32);
        ButtonFileFinancial.TabIndex = 1;
        ButtonFileFinancial.Text = "Buscar";
        ButtonFileFinancial.UseVisualStyleBackColor = false;
        ButtonFileFinancial.Click += ButtonFileFinancial_Click;
        // 
        // OpenFileDialog
        // 
        OpenFileDialog.Filter = "Arquivo Excel (.xls) | *.xls";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(120, 25);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(278, 21);
        label1.TabIndex = 2;
        label1.Text = "Selecione o arquivo da Razão Contábil:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(120, 25);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(379, 21);
        label2.TabIndex = 3;
        label2.Text = "Selecione o arquivo da Razão Auxiliar Contas a Pagar:";
        // 
        // TextBoxAccountingPath
        // 
        TextBoxAccountingPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        TextBoxAccountingPath.Location = new Point(15, 60);
        TextBoxAccountingPath.Name = "TextBoxAccountingPath";
        TextBoxAccountingPath.ReadOnly = true;
        TextBoxAccountingPath.Size = new Size(96, 25);
        TextBoxAccountingPath.TabIndex = 4;
        TextBoxAccountingPath.Visible = false;
        TextBoxAccountingPath.TextChanged += TextBoxAccountingPath_TextChanged;
        // 
        // TextBoxFinancialPath
        // 
        TextBoxFinancialPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        TextBoxFinancialPath.Location = new Point(15, 60);
        TextBoxFinancialPath.Name = "TextBoxFinancialPath";
        TextBoxFinancialPath.ReadOnly = true;
        TextBoxFinancialPath.Size = new Size(96, 25);
        TextBoxFinancialPath.TabIndex = 5;
        TextBoxFinancialPath.Visible = false;
        TextBoxFinancialPath.TextChanged += TextBoxFinancialPath_TextChanged;
        // 
        // ButtonContinue
        // 
        ButtonContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        ButtonContinue.BackColor = Color.Lime;
        ButtonContinue.Location = new Point(572, 13);
        ButtonContinue.Name = "ButtonContinue";
        ButtonContinue.Size = new Size(100, 40);
        ButtonContinue.TabIndex = 6;
        ButtonContinue.Text = "Continuar";
        ButtonContinue.UseVisualStyleBackColor = false;
        ButtonContinue.Click += ButtonContinue_Click;
        // 
        // ButtonHelp
        // 
        ButtonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ButtonHelp.BackColor = Color.Khaki;
        ButtonHelp.Location = new Point(18, 12);
        ButtonHelp.Name = "ButtonHelp";
        ButtonHelp.Size = new Size(100, 40);
        ButtonHelp.TabIndex = 8;
        ButtonHelp.Text = "Ajuda";
        ButtonHelp.UseVisualStyleBackColor = false;
        ButtonHelp.Click += ButtonHelp_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(ButtonClose);
        panel1.Controls.Add(ButtonContinue);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 221);
        panel1.Name = "panel1";
        panel1.Size = new Size(684, 65);
        panel1.TabIndex = 9;
        // 
        // panel2
        // 
        panel2.Controls.Add(ButtonHelp);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(554, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(130, 221);
        panel2.TabIndex = 10;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(TextBoxAccountingPath);
        splitContainer1.Panel1.Controls.Add(ButtonFileAccounting);
        splitContainer1.Panel1.Controls.Add(label1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(TextBoxFinancialPath);
        splitContainer1.Panel2.Controls.Add(ButtonFileFinancial);
        splitContainer1.Panel2.Controls.Add(label2);
        splitContainer1.Size = new Size(554, 221);
        splitContainer1.SplitterDistance = 109;
        splitContainer1.TabIndex = 13;
        // 
        // FormSelectFiles
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Pink;
        ClientSize = new Size(684, 286);
        Controls.Add(splitContainer1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimumSize = new Size(700, 325);
        Name = "FormSelectFiles";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Encontrar Divergências";
        KeyDown += FormSelectFiles_KeyDown;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button ButtonFileAccounting;
    private Button ButtonFileFinancial;
    private OpenFileDialog OpenFileDialog;
    private Label label1;
    private Label label2;
    private TextBox TextBoxAccountingPath;
    private TextBox TextBoxFinancialPath;
    private Button ButtonContinue;
    private Button ButtonClose;
    private Button ButtonHelp;
    private Panel panel1;
    private Panel panel2;
    private SplitContainer splitContainer1;
}