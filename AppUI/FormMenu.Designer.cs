namespace AppUI
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            LabelStatus = new Label();
            ButtonStart = new Button();
            LabelLoading = new Label();
            ListViewMatch = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            LabelLog = new Label();
            SuspendLayout();
            // 
            // LabelStatus
            // 
            LabelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelStatus.AutoSize = true;
            LabelStatus.Location = new Point(595, 515);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(55, 21);
            LabelStatus.TabIndex = 11;
            LabelStatus.Text = "Status:";
            LabelStatus.Visible = false;
            // 
            // ButtonStart
            // 
            ButtonStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonStart.BackColor = Color.DarkTurquoise;
            ButtonStart.Location = new Point(538, 12);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(134, 39);
            ButtonStart.TabIndex = 0;
            ButtonStart.Text = "Iniciar Leitura";
            ButtonStart.UseVisualStyleBackColor = false;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // LabelLoading
            // 
            LabelLoading.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelLoading.AutoSize = true;
            LabelLoading.Location = new Point(538, 65);
            LabelLoading.Name = "LabelLoading";
            LabelLoading.Size = new Size(101, 21);
            LabelLoading.TabIndex = 3;
            LabelLoading.Text = "Carregando...";
            LabelLoading.Visible = false;
            // 
            // ListViewMatch
            // 
            ListViewMatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListViewMatch.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader8, columnHeader5, columnHeader6 });
            ListViewMatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ListViewMatch.FullRowSelect = true;
            ListViewMatch.GridLines = true;
            ListViewMatch.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewMatch.Location = new Point(12, 50);
            ListViewMatch.Name = "ListViewMatch";
            ListViewMatch.Size = new Size(506, 545);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(313, 21);
            label1.TabIndex = 9;
            label1.Text = "Dê duplo-clique na linha para abrir detalhes";
            // 
            // LabelLog
            // 
            LabelLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelLog.BackColor = Color.MediumTurquoise;
            LabelLog.BorderStyle = BorderStyle.FixedSingle;
            LabelLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLog.Location = new Point(578, 541);
            LabelLog.Name = "LabelLog";
            LabelLog.Size = new Size(94, 54);
            LabelLog.TabIndex = 10;
            LabelLog.Text = "LOG";
            LabelLog.TextAlign = ContentAlignment.MiddleCenter;
            LabelLog.Visible = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(684, 607);
            Controls.Add(LabelStatus);
            Controls.Add(LabelLog);
            Controls.Add(label1);
            Controls.Add(ListViewMatch);
            Controls.Add(LabelLoading);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStart;
        private Label LabelLoading;
        private ListView ListViewMatch;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Label LabelLog;
        private Label LabelStatus;
    }
}