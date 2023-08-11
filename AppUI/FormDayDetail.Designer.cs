namespace AppUI;

partial class FormDayDetail
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Label label1;
        Label label2;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDayDetail));
        MainTableLayoutPanel = new TableLayoutPanel();
        LabelInfoAccouting = new Label();
        ListViewAccounting = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        columnHeader9 = new ColumnHeader();
        columnHeader6 = new ColumnHeader();
        ListViewFinancial = new ListView();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader7 = new ColumnHeader();
        columnHeader10 = new ColumnHeader();
        columnHeader8 = new ColumnHeader();
        LabelInfoFinancial = new Label();
        label1 = new Label();
        label2 = new Label();
        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(536, 30);
        label1.TabIndex = 8;
        label1.Text = "Informações Razão Contábil:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.AutoSize = true;
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        MainTableLayoutPanel.Controls.Add(LabelInfoAccouting, 0, 1);
        MainTableLayoutPanel.Controls.Add(label2, 1, 0);
        MainTableLayoutPanel.Controls.Add(ListViewAccounting, 0, 2);
        MainTableLayoutPanel.Controls.Add(label1, 0, 0);
        MainTableLayoutPanel.Controls.Add(ListViewFinancial, 1, 2);
        MainTableLayoutPanel.Controls.Add(LabelInfoFinancial, 1, 1);
        MainTableLayoutPanel.Dock = DockStyle.Fill;
        MainTableLayoutPanel.Location = new Point(0, 0);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 3;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Size = new Size(1084, 661);
        MainTableLayoutPanel.TabIndex = 10;
        // 
        // LabelInfoAccouting
        // 
        LabelInfoAccouting.Dock = DockStyle.Fill;
        LabelInfoAccouting.Location = new Point(3, 30);
        LabelInfoAccouting.Name = "LabelInfoAccouting";
        LabelInfoAccouting.Size = new Size(536, 30);
        LabelInfoAccouting.TabIndex = 11;
        LabelInfoAccouting.Text = "MUTAVEL";
        LabelInfoAccouting.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(545, 0);
        label2.Name = "label2";
        label2.Size = new Size(536, 30);
        label2.TabIndex = 9;
        label2.Text = "Informações Razão Auxiliar Contas a Pagar:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ListViewAccounting
        // 
        ListViewAccounting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ListViewAccounting.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader9, columnHeader6 });
        ListViewAccounting.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ListViewAccounting.FullRowSelect = true;
        ListViewAccounting.GridLines = true;
        ListViewAccounting.Location = new Point(3, 63);
        ListViewAccounting.MultiSelect = false;
        ListViewAccounting.Name = "ListViewAccounting";
        ListViewAccounting.Size = new Size(536, 595);
        ListViewAccounting.TabIndex = 1;
        ListViewAccounting.UseCompatibleStateImageBehavior = false;
        ListViewAccounting.View = View.Details;
        ListViewAccounting.ColumnClick += ListViewAccounting_ColumnClick;
        ListViewAccounting.ItemActivate += ListViewAccounting_ItemActivate;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Nota Fiscal";
        columnHeader1.Width = 100;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Total Crédito";
        columnHeader2.Width = 100;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Total Débito";
        columnHeader5.Width = 100;
        // 
        // columnHeader9
        // 
        columnHeader9.Text = "Diferença";
        columnHeader9.Width = 100;
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "Descrição";
        columnHeader6.Width = 100;
        // 
        // ListViewFinancial
        // 
        ListViewFinancial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ListViewFinancial.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader7, columnHeader10, columnHeader8 });
        ListViewFinancial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ListViewFinancial.FullRowSelect = true;
        ListViewFinancial.GridLines = true;
        ListViewFinancial.Location = new Point(545, 63);
        ListViewFinancial.MultiSelect = false;
        ListViewFinancial.Name = "ListViewFinancial";
        ListViewFinancial.Size = new Size(536, 595);
        ListViewFinancial.TabIndex = 2;
        ListViewFinancial.UseCompatibleStateImageBehavior = false;
        ListViewFinancial.View = View.Details;
        ListViewFinancial.ColumnClick += ListViewFinancial_ColumnClick;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Nota Fiscal";
        columnHeader3.Width = 100;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Total Crédito";
        columnHeader4.Width = 100;
        // 
        // columnHeader7
        // 
        columnHeader7.Text = "Total Débito";
        columnHeader7.Width = 100;
        // 
        // columnHeader10
        // 
        columnHeader10.Text = "Diferença";
        columnHeader10.Width = 100;
        // 
        // columnHeader8
        // 
        columnHeader8.Text = "Descrição";
        columnHeader8.Width = 100;
        // 
        // LabelInfoFinancial
        // 
        LabelInfoFinancial.Dock = DockStyle.Fill;
        LabelInfoFinancial.Location = new Point(545, 30);
        LabelInfoFinancial.Name = "LabelInfoFinancial";
        LabelInfoFinancial.Size = new Size(536, 30);
        LabelInfoFinancial.TabIndex = 10;
        LabelInfoFinancial.Text = "MUTAVEL";
        LabelInfoFinancial.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormDayDetail
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.MediumPurple;
        ClientSize = new Size(1084, 661);
        Controls.Add(MainTableLayoutPanel);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Margin = new Padding(4);
        Name = "FormDayDetail";
        StartPosition = FormStartPosition.CenterParent;
        Text = "MUTAVEL";
        WindowState = FormWindowState.Maximized;
        KeyDown += FormDayDetail_KeyDown;
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TableLayoutPanel MainTableLayoutPanel;
    private ListView ListViewAccounting;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ListView ListViewFinancial;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Label label2;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private Label LabelInfoAccouting;
    private Label LabelInfoFinancial;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader10;
}