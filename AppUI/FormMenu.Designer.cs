namespace AppUI;

partial class FormMenu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
        LabelStatus = new Label();
        ButtonStart = new Button();
        ListViewMatch = new ListView();
        columnHeader9 = new ColumnHeader();
        columnHeader8 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        columnHeader6 = new ColumnHeader();
        LabelLog = new Label();
        GroupBoxLog = new GroupBox();
        ListViewLog = new ListView();
        Main = new ColumnHeader();
        LabelRowLine = new Label();
        label1 = new Label();
        GroupBoxLog.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 30);
        label1.Name = "label1";
        label1.Size = new Size(313, 21);
        label1.TabIndex = 9;
        label1.Text = "Dê duplo-clique na linha para abrir detalhes";
        // 
        // LabelStatus
        // 
        LabelStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LabelStatus.AutoSize = true;
        LabelStatus.Location = new Point(513, 39);
        LabelStatus.Name = "LabelStatus";
        LabelStatus.Size = new Size(55, 21);
        LabelStatus.TabIndex = 11;
        LabelStatus.Text = "Status:";
        LabelStatus.Visible = false;
        // 
        // ButtonStart
        // 
        ButtonStart.BackColor = Color.DarkTurquoise;
        ButtonStart.Location = new Point(358, 24);
        ButtonStart.Name = "ButtonStart";
        ButtonStart.Size = new Size(134, 39);
        ButtonStart.TabIndex = 0;
        ButtonStart.Text = "Iniciar Leitura";
        ButtonStart.UseVisualStyleBackColor = false;
        ButtonStart.Click += ButtonStart_Click;
        // 
        // ListViewMatch
        // 
        ListViewMatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ListViewMatch.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader8, columnHeader5, columnHeader6 });
        ListViewMatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ListViewMatch.FullRowSelect = true;
        ListViewMatch.GridLines = true;
        ListViewMatch.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        ListViewMatch.Location = new Point(12, 66);
        ListViewMatch.MultiSelect = false;
        ListViewMatch.Name = "ListViewMatch";
        ListViewMatch.Size = new Size(660, 483);
        ListViewMatch.TabIndex = 8;
        ListViewMatch.UseCompatibleStateImageBehavior = false;
        ListViewMatch.View = View.Details;
        ListViewMatch.ItemActivate += ListViewMatch_ItemActivate;
        // 
        // columnHeader9
        // 
        columnHeader9.Text = "Data";
        columnHeader9.Width = 100;
        // 
        // columnHeader8
        // 
        columnHeader8.Text = "Diferença Crédito";
        columnHeader8.Width = 100;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Diferença Débito";
        columnHeader5.Width = 100;
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "Diferença Total";
        columnHeader6.Width = 100;
        // 
        // LabelLog
        // 
        LabelLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LabelLog.BackColor = Color.MediumTurquoise;
        LabelLog.BorderStyle = BorderStyle.FixedSingle;
        LabelLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        LabelLog.Location = new Point(578, 9);
        LabelLog.Name = "LabelLog";
        LabelLog.Size = new Size(94, 54);
        LabelLog.TabIndex = 10;
        LabelLog.Text = "LOG";
        LabelLog.TextAlign = ContentAlignment.MiddleCenter;
        LabelLog.Visible = false;
        // 
        // GroupBoxLog
        // 
        GroupBoxLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        GroupBoxLog.Controls.Add(ListViewLog);
        GroupBoxLog.Controls.Add(LabelRowLine);
        GroupBoxLog.Location = new Point(12, 383);
        GroupBoxLog.Name = "GroupBoxLog";
        GroupBoxLog.Size = new Size(660, 166);
        GroupBoxLog.TabIndex = 12;
        GroupBoxLog.TabStop = false;
        GroupBoxLog.Text = "LOGFILENAME";
        GroupBoxLog.Visible = false;
        GroupBoxLog.Resize += GroupBoxLog_Resize;
        // 
        // ListViewLog
        // 
        ListViewLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ListViewLog.Columns.AddRange(new ColumnHeader[] { Main });
        ListViewLog.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ListViewLog.FullRowSelect = true;
        ListViewLog.GridLines = true;
        ListViewLog.HeaderStyle = ColumnHeaderStyle.None;
        ListViewLog.Location = new Point(6, 53);
        ListViewLog.MultiSelect = false;
        ListViewLog.Name = "ListViewLog";
        ListViewLog.Size = new Size(648, 107);
        ListViewLog.TabIndex = 9;
        ListViewLog.UseCompatibleStateImageBehavior = false;
        ListViewLog.View = View.Details;
        // 
        // Main
        // 
        Main.Text = "Main";
        Main.Width = 620;
        // 
        // LabelRowLine
        // 
        LabelRowLine.AutoSize = true;
        LabelRowLine.Location = new Point(16, 27);
        LabelRowLine.Name = "LabelRowLine";
        LabelRowLine.Size = new Size(109, 21);
        LabelRowLine.TabIndex = 0;
        LabelRowLine.Text = "LOGROWLINE";
        // 
        // FormMenu
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkSeaGreen;
        ClientSize = new Size(684, 561);
        Controls.Add(GroupBoxLog);
        Controls.Add(LabelStatus);
        Controls.Add(LabelLog);
        Controls.Add(label1);
        Controls.Add(ListViewMatch);
        Controls.Add(ButtonStart);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Margin = new Padding(4);
        MinimumSize = new Size(700, 400);
        Name = "FormMenu";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Calcular e Comparar";
        KeyDown += FormMenu_KeyDown;
        GroupBoxLog.ResumeLayout(false);
        GroupBoxLog.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button ButtonStart;
    private ListView ListViewMatch;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private Label label1;
    private Label LabelLog;
    private Label LabelStatus;
    private GroupBox GroupBoxLog;
    private Label LabelRowLine;
    private ListView ListViewLog;
    private ColumnHeader Main;
}