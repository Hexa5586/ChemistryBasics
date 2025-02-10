namespace ChemistryBasics
{
    partial class PerfectRankingPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tblpnlRanks = new TableLayoutPanel();
            btnStart = new Sunny.UI.UIButton();
            tblpnlTitle = new TableLayoutPanel();
            lbl2 = new Label();
            btnRankingsClear = new Sunny.UI.UIButton();
            tblpnlMode = new TableLayoutPanel();
            lbl1 = new Label();
            cmbMode = new Sunny.UI.UIComboBox();
            dataRanks = new Sunny.UI.UIDataGridView();
            dcolRank = new DataGridViewTextBoxColumn();
            dcolName = new DataGridViewTextBoxColumn();
            dcolTime = new DataGridViewTextBoxColumn();
            tblpnlRanks.SuspendLayout();
            tblpnlTitle.SuspendLayout();
            tblpnlMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRanks).BeginInit();
            SuspendLayout();
            // 
            // tblpnlRanks
            // 
            tblpnlRanks.ColumnCount = 1;
            tblpnlRanks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlRanks.Controls.Add(btnStart, 0, 3);
            tblpnlRanks.Controls.Add(tblpnlTitle, 0, 0);
            tblpnlRanks.Controls.Add(tblpnlMode, 0, 2);
            tblpnlRanks.Controls.Add(dataRanks, 0, 1);
            tblpnlRanks.Dock = DockStyle.Fill;
            tblpnlRanks.Location = new Point(0, 0);
            tblpnlRanks.Name = "tblpnlRanks";
            tblpnlRanks.RowCount = 4;
            tblpnlRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlRanks.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlRanks.Size = new Size(921, 902);
            tblpnlRanks.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnStart.Location = new Point(3, 835);
            btnStart.MinimumSize = new Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(915, 64);
            btnStart.TabIndex = 6;
            btnStart.Text = "挑战准备";
            btnStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStart.Click += btnStart_Click;
            // 
            // tblpnlTitle
            // 
            tblpnlTitle.ColumnCount = 2;
            tblpnlTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblpnlTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblpnlTitle.Controls.Add(lbl2, 0, 0);
            tblpnlTitle.Controls.Add(btnRankingsClear, 1, 0);
            tblpnlTitle.Dock = DockStyle.Fill;
            tblpnlTitle.Location = new Point(3, 3);
            tblpnlTitle.Name = "tblpnlTitle";
            tblpnlTitle.RowCount = 1;
            tblpnlTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlTitle.Size = new Size(915, 64);
            tblpnlTitle.TabIndex = 7;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl2.Location = new Point(3, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(726, 64);
            lbl2.TabIndex = 0;
            lbl2.Text = "完美挑战模式排行榜";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRankingsClear
            // 
            btnRankingsClear.Dock = DockStyle.Fill;
            btnRankingsClear.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnRankingsClear.Location = new Point(735, 3);
            btnRankingsClear.MinimumSize = new Size(1, 1);
            btnRankingsClear.Name = "btnRankingsClear";
            btnRankingsClear.Size = new Size(177, 58);
            btnRankingsClear.TabIndex = 1;
            btnRankingsClear.Text = "清空排行榜";
            btnRankingsClear.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnRankingsClear.Click += btnRankingsClear_Click;
            // 
            // tblpnlMode
            // 
            tblpnlMode.ColumnCount = 2;
            tblpnlMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblpnlMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblpnlMode.Controls.Add(lbl1, 0, 0);
            tblpnlMode.Controls.Add(cmbMode, 1, 0);
            tblpnlMode.Dock = DockStyle.Fill;
            tblpnlMode.Location = new Point(3, 765);
            tblpnlMode.Name = "tblpnlMode";
            tblpnlMode.RowCount = 1;
            tblpnlMode.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlMode.Size = new Size(915, 64);
            tblpnlMode.TabIndex = 5;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ButtonFace;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Microsoft YaHei UI", 12F);
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(177, 64);
            lbl1.TabIndex = 0;
            lbl1.Text = "模式";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbMode
            // 
            cmbMode.DataSource = null;
            cmbMode.Dock = DockStyle.Fill;
            cmbMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbMode.FillColor = Color.White;
            cmbMode.Font = new Font("微软雅黑", 12F);
            cmbMode.ItemHeight = 35;
            cmbMode.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbMode.Items.AddRange(new object[] { "元素符号", "化学式" });
            cmbMode.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbMode.Location = new Point(187, 5);
            cmbMode.Margin = new Padding(4, 5, 4, 5);
            cmbMode.MinimumSize = new Size(63, 0);
            cmbMode.Name = "cmbMode";
            cmbMode.Padding = new Padding(0, 0, 30, 2);
            cmbMode.Size = new Size(724, 54);
            cmbMode.SymbolSize = 24;
            cmbMode.TabIndex = 1;
            cmbMode.TextAlignment = ContentAlignment.MiddleLeft;
            cmbMode.Watermark = "";
            cmbMode.SelectedIndexChanged += cmbMode_SelectedIndexChanged;
            // 
            // dataRanks
            // 
            dataRanks.AllowUserToAddRows = false;
            dataRanks.AllowUserToDeleteRows = false;
            dataRanks.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dataRanks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataRanks.BackgroundColor = Color.White;
            dataRanks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataRanks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataRanks.ColumnHeadersHeight = 50;
            dataRanks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataRanks.Columns.AddRange(new DataGridViewColumn[] { dcolRank, dcolName, dcolTime });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 24F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataRanks.DefaultCellStyle = dataGridViewCellStyle8;
            dataRanks.Dock = DockStyle.Fill;
            dataRanks.Enabled = false;
            dataRanks.EnableHeadersVisualStyles = false;
            dataRanks.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataRanks.GridColor = Color.FromArgb(80, 160, 255);
            dataRanks.Location = new Point(3, 73);
            dataRanks.MultiSelect = false;
            dataRanks.Name = "dataRanks";
            dataRanks.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataRanks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataRanks.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataRanks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataRanks.RowTemplate.DefaultCellStyle.Font = new Font("微软雅黑", 16F);
            dataRanks.RowTemplate.Height = 50;
            dataRanks.ScrollMode = Sunny.UI.UIDataGridView.UIDataGridViewScrollMode.Page;
            dataRanks.SelectedIndex = -1;
            dataRanks.Size = new Size(915, 686);
            dataRanks.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataRanks.TabIndex = 4;
            // 
            // dcolRank
            // 
            dcolRank.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolRank.HeaderText = "排名";
            dcolRank.MinimumWidth = 8;
            dcolRank.Name = "dcolRank";
            dcolRank.ReadOnly = true;
            // 
            // dcolName
            // 
            dcolName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolName.HeaderText = "姓名";
            dcolName.MinimumWidth = 8;
            dcolName.Name = "dcolName";
            dcolName.ReadOnly = true;
            // 
            // dcolTime
            // 
            dcolTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolTime.HeaderText = "用时";
            dcolTime.MinimumWidth = 8;
            dcolTime.Name = "dcolTime";
            dcolTime.ReadOnly = true;
            // 
            // PerfectRankingPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlRanks);
            MinimumSize = new Size(921, 902);
            Name = "PerfectRankingPanel";
            Size = new Size(921, 902);
            Load += PerfectRankingPanel_Load;
            tblpnlRanks.ResumeLayout(false);
            tblpnlTitle.ResumeLayout(false);
            tblpnlTitle.PerformLayout();
            tblpnlMode.ResumeLayout(false);
            tblpnlMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRanks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlRanks;
        private Sunny.UI.UIDataGridView dataRanks;
        private DataGridViewTextBoxColumn dcolRank;
        private DataGridViewTextBoxColumn dcolName;
        private DataGridViewTextBoxColumn dcolTime;
        private TableLayoutPanel tblpnlMode;
        private Label lbl1;
        private Sunny.UI.UIComboBox cmbMode;
        private Sunny.UI.UIButton btnStart;
        private TableLayoutPanel tblpnlTitle;
        private Label lbl2;
        private Sunny.UI.UIButton btnRankingsClear;
    }
}
