namespace ChemistryBasics
{
    partial class ResultPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tblpnlResult = new TableLayoutPanel();
            btnClose = new Sunny.UI.UIButton();
            tblpnlTitle = new TableLayoutPanel();
            lblMode = new Label();
            lblCorrectnTotal = new Label();
            tblpnlScoreRank = new TableLayoutPanel();
            lblAchievement = new Label();
            lblRank = new Label();
            dataErrors = new Sunny.UI.UIDataGridView();
            dcolQuestion = new DataGridViewTextBoxColumn();
            dcolCorrectAnswer = new DataGridViewTextBoxColumn();
            dcolWrongAnswer = new DataGridViewTextBoxColumn();
            tblpnlResult.SuspendLayout();
            tblpnlTitle.SuspendLayout();
            tblpnlScoreRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataErrors).BeginInit();
            SuspendLayout();
            // 
            // tblpnlResult
            // 
            tblpnlResult.ColumnCount = 1;
            tblpnlResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlResult.Controls.Add(btnClose, 0, 3);
            tblpnlResult.Controls.Add(tblpnlTitle, 0, 0);
            tblpnlResult.Controls.Add(tblpnlScoreRank, 0, 1);
            tblpnlResult.Controls.Add(dataErrors, 0, 2);
            tblpnlResult.Dock = DockStyle.Fill;
            tblpnlResult.Location = new Point(0, 0);
            tblpnlResult.Name = "tblpnlResult";
            tblpnlResult.RowCount = 4;
            tblpnlResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlResult.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblpnlResult.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblpnlResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlResult.Size = new Size(1102, 1096);
            tblpnlResult.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnClose.Location = new Point(3, 1028);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(1096, 65);
            btnClose.TabIndex = 0;
            btnClose.Text = "关闭";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // tblpnlTitle
            // 
            tblpnlTitle.ColumnCount = 2;
            tblpnlTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblpnlTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblpnlTitle.Controls.Add(lblMode, 0, 0);
            tblpnlTitle.Controls.Add(lblCorrectnTotal, 1, 0);
            tblpnlTitle.Dock = DockStyle.Fill;
            tblpnlTitle.Location = new Point(3, 3);
            tblpnlTitle.Name = "tblpnlTitle";
            tblpnlTitle.RowCount = 1;
            tblpnlTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlTitle.Size = new Size(1096, 64);
            tblpnlTitle.TabIndex = 1;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Dock = DockStyle.Fill;
            lblMode.Font = new Font("Microsoft YaHei UI", 14F);
            lblMode.Location = new Point(3, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(651, 64);
            lblMode.TabIndex = 0;
            lblMode.Text = "MODE";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorrectnTotal
            // 
            lblCorrectnTotal.AutoSize = true;
            lblCorrectnTotal.Dock = DockStyle.Fill;
            lblCorrectnTotal.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCorrectnTotal.Location = new Point(660, 0);
            lblCorrectnTotal.Name = "lblCorrectnTotal";
            lblCorrectnTotal.Size = new Size(433, 64);
            lblCorrectnTotal.TabIndex = 1;
            lblCorrectnTotal.Text = "X/X";
            lblCorrectnTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblpnlScoreRank
            // 
            tblpnlScoreRank.ColumnCount = 2;
            tblpnlScoreRank.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblpnlScoreRank.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblpnlScoreRank.Controls.Add(lblAchievement, 0, 0);
            tblpnlScoreRank.Controls.Add(lblRank, 1, 0);
            tblpnlScoreRank.Dock = DockStyle.Fill;
            tblpnlScoreRank.Location = new Point(3, 73);
            tblpnlScoreRank.Name = "tblpnlScoreRank";
            tblpnlScoreRank.RowCount = 1;
            tblpnlScoreRank.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlScoreRank.Size = new Size(1096, 376);
            tblpnlScoreRank.TabIndex = 2;
            // 
            // lblAchievement
            // 
            lblAchievement.AutoSize = true;
            lblAchievement.Dock = DockStyle.Fill;
            lblAchievement.Font = new Font("Unispace", 76F, FontStyle.Bold);
            lblAchievement.Location = new Point(3, 0);
            lblAchievement.Name = "lblAchievement";
            lblAchievement.Size = new Size(706, 376);
            lblAchievement.TabIndex = 0;
            lblAchievement.Text = "XX.X%";
            lblAchievement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Dock = DockStyle.Fill;
            lblRank.Font = new Font("Unispace", 110F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRank.Location = new Point(715, 0);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(378, 376);
            lblRank.TabIndex = 1;
            lblRank.Text = "RA";
            lblRank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataErrors
            // 
            dataErrors.AllowUserToAddRows = false;
            dataErrors.AllowUserToDeleteRows = false;
            dataErrors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dataErrors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataErrors.BackgroundColor = Color.White;
            dataErrors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataErrors.ColumnHeadersHeight = 50;
            dataErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataErrors.Columns.AddRange(new DataGridViewColumn[] { dcolQuestion, dcolCorrectAnswer, dcolWrongAnswer });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 24F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataErrors.DefaultCellStyle = dataGridViewCellStyle3;
            dataErrors.Dock = DockStyle.Fill;
            dataErrors.Enabled = false;
            dataErrors.EnableHeadersVisualStyles = false;
            dataErrors.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataErrors.GridColor = Color.FromArgb(80, 160, 255);
            dataErrors.Location = new Point(3, 455);
            dataErrors.MultiSelect = false;
            dataErrors.Name = "dataErrors";
            dataErrors.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataErrors.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataErrors.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataErrors.RowTemplate.DefaultCellStyle.Font = new Font("微软雅黑", 24F);
            dataErrors.RowTemplate.Height = 80;
            dataErrors.ScrollMode = Sunny.UI.UIDataGridView.UIDataGridViewScrollMode.Page;
            dataErrors.SelectedIndex = -1;
            dataErrors.Size = new Size(1096, 567);
            dataErrors.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataErrors.TabIndex = 3;
            // 
            // dcolQuestion
            // 
            dcolQuestion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolQuestion.HeaderText = "题目";
            dcolQuestion.MinimumWidth = 8;
            dcolQuestion.Name = "dcolQuestion";
            dcolQuestion.ReadOnly = true;
            // 
            // dcolCorrectAnswer
            // 
            dcolCorrectAnswer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolCorrectAnswer.HeaderText = "正确答案";
            dcolCorrectAnswer.MinimumWidth = 8;
            dcolCorrectAnswer.Name = "dcolCorrectAnswer";
            dcolCorrectAnswer.ReadOnly = true;
            // 
            // dcolWrongAnswer
            // 
            dcolWrongAnswer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolWrongAnswer.HeaderText = "你的答案";
            dcolWrongAnswer.MinimumWidth = 8;
            dcolWrongAnswer.Name = "dcolWrongAnswer";
            dcolWrongAnswer.ReadOnly = true;
            // 
            // ResultPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlResult);
            MinimumSize = new Size(1102, 1096);
            Name = "ResultPanel";
            Size = new Size(1102, 1096);
            Load += ResultPanel_Load;
            Resize += ResultPanel_Resize;
            tblpnlResult.ResumeLayout(false);
            tblpnlTitle.ResumeLayout(false);
            tblpnlTitle.PerformLayout();
            tblpnlScoreRank.ResumeLayout(false);
            tblpnlScoreRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataErrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlResult;
        private Sunny.UI.UIButton btnClose;
        private TableLayoutPanel tblpnlTitle;
        private TableLayoutPanel tblpnlScoreRank;
        private Sunny.UI.UIDataGridView dataErrors;
        private Label lblMode;
        private Label lblCorrectnTotal;
        private Label lblAchievement;
        private Label lblRank;
        private DataGridViewTextBoxColumn dcolQuestion;
        private DataGridViewTextBoxColumn dcolCorrectAnswer;
        private DataGridViewTextBoxColumn dcolWrongAnswer;
    }
}
