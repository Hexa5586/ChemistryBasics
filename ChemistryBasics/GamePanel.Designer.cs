namespace ChemistryBasics
{
    partial class GamePanel
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
            tblpnlGame = new TableLayoutPanel();
            btnSubmit = new Sunny.UI.UIButton();
            tblpnlStatus = new TableLayoutPanel();
            lbl2 = new Label();
            lblProgress = new Label();
            lblAccuracy = new Label();
            lbl1 = new Label();
            lblAnswerStatus = new Label();
            tblpnlQuestion = new TableLayoutPanel();
            lbl3 = new Label();
            txtQuestion = new Sunny.UI.UITextBox();
            tblpnlAnswer = new TableLayoutPanel();
            txtAnswer = new Sunny.UI.UITextBox();
            lbl4 = new Label();
            tblpnlGame.SuspendLayout();
            tblpnlStatus.SuspendLayout();
            tblpnlQuestion.SuspendLayout();
            tblpnlAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlGame
            // 
            tblpnlGame.ColumnCount = 1;
            tblpnlGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlGame.Controls.Add(btnSubmit, 0, 3);
            tblpnlGame.Controls.Add(tblpnlStatus, 0, 0);
            tblpnlGame.Controls.Add(tblpnlQuestion, 0, 1);
            tblpnlGame.Controls.Add(tblpnlAnswer, 0, 2);
            tblpnlGame.Dock = DockStyle.Fill;
            tblpnlGame.Location = new Point(0, 0);
            tblpnlGame.Name = "tblpnlGame";
            tblpnlGame.RowCount = 4;
            tblpnlGame.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlGame.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tblpnlGame.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tblpnlGame.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlGame.Size = new Size(1102, 1096);
            tblpnlGame.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSubmit.Location = new Point(3, 1028);
            btnSubmit.MinimumSize = new Size(1, 1);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(1096, 65);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "确认";
            btnSubmit.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tblpnlStatus
            // 
            tblpnlStatus.BackColor = Color.FromArgb(243, 249, 255);
            tblpnlStatus.ColumnCount = 5;
            tblpnlStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2859163F));
            tblpnlStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2859182F));
            tblpnlStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8563271F));
            tblpnlStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2859182F));
            tblpnlStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2859182F));
            tblpnlStatus.Controls.Add(lbl2, 0, 0);
            tblpnlStatus.Controls.Add(lblProgress, 1, 0);
            tblpnlStatus.Controls.Add(lblAccuracy, 4, 0);
            tblpnlStatus.Controls.Add(lbl1, 3, 0);
            tblpnlStatus.Controls.Add(lblAnswerStatus, 2, 0);
            tblpnlStatus.Dock = DockStyle.Fill;
            tblpnlStatus.Location = new Point(3, 3);
            tblpnlStatus.Name = "tblpnlStatus";
            tblpnlStatus.RowCount = 1;
            tblpnlStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlStatus.Size = new Size(1096, 64);
            tblpnlStatus.TabIndex = 0;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Microsoft YaHei UI", 12F);
            lbl2.Location = new Point(3, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(150, 64);
            lbl2.TabIndex = 1;
            lbl2.Text = "进度";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Dock = DockStyle.Fill;
            lblProgress.Font = new Font("Microsoft YaHei UI", 12F);
            lblProgress.Location = new Point(159, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(150, 64);
            lblProgress.TabIndex = 3;
            lblProgress.Text = "X/X";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Dock = DockStyle.Fill;
            lblAccuracy.Font = new Font("Microsoft YaHei UI", 12F);
            lblAccuracy.Location = new Point(940, 0);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(153, 64);
            lblAccuracy.TabIndex = 2;
            lblAccuracy.Text = "XXs";
            lblAccuracy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Microsoft YaHei UI", 12F);
            lbl1.Location = new Point(784, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(150, 64);
            lbl1.TabIndex = 0;
            lbl1.Text = "正确率";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswerStatus
            // 
            lblAnswerStatus.AutoSize = true;
            lblAnswerStatus.Dock = DockStyle.Fill;
            lblAnswerStatus.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblAnswerStatus.Location = new Point(315, 0);
            lblAnswerStatus.Name = "lblAnswerStatus";
            lblAnswerStatus.Size = new Size(463, 64);
            lblAnswerStatus.TabIndex = 4;
            lblAnswerStatus.Text = "STATUS";
            lblAnswerStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblpnlQuestion
            // 
            tblpnlQuestion.BackColor = Color.White;
            tblpnlQuestion.ColumnCount = 1;
            tblpnlQuestion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlQuestion.Controls.Add(lbl3, 0, 0);
            tblpnlQuestion.Controls.Add(txtQuestion, 0, 1);
            tblpnlQuestion.Dock = DockStyle.Fill;
            tblpnlQuestion.Location = new Point(3, 73);
            tblpnlQuestion.Name = "tblpnlQuestion";
            tblpnlQuestion.RowCount = 2;
            tblpnlQuestion.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlQuestion.RowStyles.Add(new RowStyle());
            tblpnlQuestion.Size = new Size(1096, 352);
            tblpnlQuestion.TabIndex = 1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.FromArgb(243, 249, 255);
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Microsoft YaHei UI", 12F);
            lbl3.Location = new Point(3, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(1090, 50);
            lbl3.TabIndex = 0;
            lbl3.Text = "问题";
            lbl3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.FillReadOnlyColor = Color.White;
            txtQuestion.Font = new Font("微软雅黑", 80F);
            txtQuestion.Location = new Point(4, 74);
            txtQuestion.Margin = new Padding(4, 5, 4, 5);
            txtQuestion.MinimumSize = new Size(1, 16);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Padding = new Padding(5);
            txtQuestion.ReadOnly = true;
            txtQuestion.RectSides = ToolStripStatusLabelBorderSides.None;
            txtQuestion.ShowText = false;
            txtQuestion.Size = new Size(1088, 254);
            txtQuestion.TabIndex = 1;
            txtQuestion.Text = "QUESTION";
            txtQuestion.TextAlignment = ContentAlignment.MiddleCenter;
            txtQuestion.Watermark = "";
            // 
            // tblpnlAnswer
            // 
            tblpnlAnswer.BackColor = Color.White;
            tblpnlAnswer.ColumnCount = 1;
            tblpnlAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlAnswer.Controls.Add(txtAnswer, 0, 1);
            tblpnlAnswer.Controls.Add(lbl4, 0, 0);
            tblpnlAnswer.Dock = DockStyle.Fill;
            tblpnlAnswer.Location = new Point(3, 431);
            tblpnlAnswer.Name = "tblpnlAnswer";
            tblpnlAnswer.RowCount = 2;
            tblpnlAnswer.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlAnswer.RowStyles.Add(new RowStyle());
            tblpnlAnswer.Size = new Size(1096, 591);
            tblpnlAnswer.TabIndex = 2;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Font = new Font("Calibri", 120F, FontStyle.Bold);
            txtAnswer.Location = new Point(4, 143);
            txtAnswer.Margin = new Padding(4, 5, 4, 5);
            txtAnswer.MinimumSize = new Size(1, 16);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Padding = new Padding(1);
            txtAnswer.RectSides = ToolStripStatusLabelBorderSides.None;
            txtAnswer.ShowText = false;
            txtAnswer.Size = new Size(1088, 354);
            txtAnswer.TabIndex = 4;
            txtAnswer.Text = "ANSWER";
            txtAnswer.TextAlignment = ContentAlignment.MiddleCenter;
            txtAnswer.Watermark = "";
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            txtAnswer.KeyDown += txtAnswer_KeyDown;
            txtAnswer.KeyPress += txtAnswer_KeyPress;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.FromArgb(243, 249, 255);
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Microsoft YaHei UI", 12F);
            lbl4.Location = new Point(3, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(1090, 50);
            lbl4.TabIndex = 1;
            lbl4.Text = "答案";
            lbl4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlGame);
            DoubleBuffered = true;
            MinimumSize = new Size(1102, 1096);
            Name = "GamePanel";
            Size = new Size(1102, 1096);
            Load += ElementModePanel_Load;
            Resize += GamePanel_Resize;
            tblpnlGame.ResumeLayout(false);
            tblpnlStatus.ResumeLayout(false);
            tblpnlStatus.PerformLayout();
            tblpnlQuestion.ResumeLayout(false);
            tblpnlQuestion.PerformLayout();
            tblpnlAnswer.ResumeLayout(false);
            tblpnlAnswer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlGame;
        private TableLayoutPanel tblpnlStatus;
        private TableLayoutPanel tblpnlQuestion;
        private TableLayoutPanel tblpnlAnswer;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lblAccuracy;
        private Label lblProgress;
        private Sunny.UI.UITextBox txtAnswer;
        private Sunny.UI.UIButton btnSubmit;
        private Label lblAnswerStatus;
        private Sunny.UI.UITextBox txtQuestion;
    }
}
