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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tblpnlResult = new TableLayoutPanel();
            btnClose = new Sunny.UI.UIButton();
            tblpnlTitle = new TableLayoutPanel();
            tblpnlScoreRank = new TableLayoutPanel();
            dataErrors = new Sunny.UI.UIDataGridView();
            dcolQuestion = new DataGridViewTextBoxColumn();
            dcolCorrectAnswer = new DataGridViewTextBoxColumn();
            dcolWrongAnswer = new DataGridViewTextBoxColumn();
            lblMode = new Label();
            lblCorrectnTotal = new Label();
            lblAccuracy = new Label();
            lblRank = new Label();
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
            tblpnlResult.Size = new Size(1000, 1000);
            tblpnlResult.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Location = new Point(3, 933);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(994, 64);
            btnClose.TabIndex = 0;
            btnClose.Text = "关闭";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
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
            tblpnlTitle.Size = new Size(994, 64);
            tblpnlTitle.TabIndex = 1;
            // 
            // tblpnlScoreRank
            // 
            tblpnlScoreRank.ColumnCount = 2;
            tblpnlScoreRank.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblpnlScoreRank.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblpnlScoreRank.Controls.Add(lblAccuracy, 0, 0);
            tblpnlScoreRank.Controls.Add(lblRank, 1, 0);
            tblpnlScoreRank.Dock = DockStyle.Fill;
            tblpnlScoreRank.Location = new Point(3, 73);
            tblpnlScoreRank.Name = "tblpnlScoreRank";
            tblpnlScoreRank.RowCount = 1;
            tblpnlScoreRank.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlScoreRank.Size = new Size(994, 338);
            tblpnlScoreRank.TabIndex = 2;
            // 
            // dataErrors
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dataErrors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataErrors.BackgroundColor = Color.White;
            dataErrors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataErrors.ColumnHeadersHeight = 50;
            dataErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataErrors.Columns.AddRange(new DataGridViewColumn[] { dcolQuestion, dcolCorrectAnswer, dcolWrongAnswer });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataErrors.DefaultCellStyle = dataGridViewCellStyle8;
            dataErrors.Dock = DockStyle.Fill;
            dataErrors.EnableHeadersVisualStyles = false;
            dataErrors.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataErrors.GridColor = Color.FromArgb(80, 160, 255);
            dataErrors.Location = new Point(3, 417);
            dataErrors.Name = "dataErrors";
            dataErrors.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataErrors.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataErrors.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataErrors.RowTemplate.Height = 50;
            dataErrors.ScrollMode = Sunny.UI.UIDataGridView.UIDataGridViewScrollMode.Page;
            dataErrors.SelectedIndex = -1;
            dataErrors.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataErrors.Size = new Size(994, 510);
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
            dcolCorrectAnswer.HeaderText = "答案";
            dcolCorrectAnswer.MinimumWidth = 8;
            dcolCorrectAnswer.Name = "dcolCorrectAnswer";
            dcolCorrectAnswer.ReadOnly = true;
            // 
            // dcolWrongAnswer
            // 
            dcolWrongAnswer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dcolWrongAnswer.HeaderText = "错误答案";
            dcolWrongAnswer.MinimumWidth = 8;
            dcolWrongAnswer.Name = "dcolWrongAnswer";
            dcolWrongAnswer.ReadOnly = true;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Dock = DockStyle.Fill;
            lblMode.Font = new Font("Microsoft YaHei UI", 12F);
            lblMode.Location = new Point(3, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(590, 64);
            lblMode.TabIndex = 0;
            lblMode.Text = "MODE";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorrectnTotal
            // 
            lblCorrectnTotal.AutoSize = true;
            lblCorrectnTotal.Dock = DockStyle.Fill;
            lblCorrectnTotal.Font = new Font("Microsoft YaHei UI", 12F);
            lblCorrectnTotal.Location = new Point(599, 0);
            lblCorrectnTotal.Name = "lblCorrectnTotal";
            lblCorrectnTotal.Size = new Size(392, 64);
            lblCorrectnTotal.TabIndex = 1;
            lblCorrectnTotal.Text = "X/X";
            lblCorrectnTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Dock = DockStyle.Fill;
            lblAccuracy.Location = new Point(3, 0);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(590, 338);
            lblAccuracy.TabIndex = 0;
            lblAccuracy.Text = "XX.XX%";
            lblAccuracy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Dock = DockStyle.Fill;
            lblRank.Location = new Point(599, 0);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(392, 338);
            lblRank.TabIndex = 1;
            lblRank.Text = "RANK";
            lblRank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlResult);
            Name = "ResultPanel";
            Size = new Size(1000, 1000);
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
        private DataGridViewTextBoxColumn dcolQuestion;
        private DataGridViewTextBoxColumn dcolCorrectAnswer;
        private DataGridViewTextBoxColumn dcolWrongAnswer;
        private Label lblMode;
        private Label lblCorrectnTotal;
        private Label lblAccuracy;
        private Label lblRank;
    }
}
