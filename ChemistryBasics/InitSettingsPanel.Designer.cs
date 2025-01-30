namespace ChemistryBasics
{
    partial class InitSettingsPanel
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
            tblpnlInitSettings = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl1 = new Label();
            numProblemCount = new Sunny.UI.UIIntegerUpDown();
            lblMode = new Label();
            btnStart = new Sunny.UI.UIButton();
            rtxtAlert = new RichTextBox();
            tblpnlInitSettings.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlInitSettings
            // 
            tblpnlInitSettings.ColumnCount = 1;
            tblpnlInitSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlInitSettings.Controls.Add(tableLayoutPanel1, 0, 2);
            tblpnlInitSettings.Controls.Add(lblMode, 0, 0);
            tblpnlInitSettings.Controls.Add(btnStart, 0, 3);
            tblpnlInitSettings.Controls.Add(rtxtAlert, 0, 1);
            tblpnlInitSettings.Dock = DockStyle.Fill;
            tblpnlInitSettings.Location = new Point(0, 0);
            tblpnlInitSettings.Name = "tblpnlInitSettings";
            tblpnlInitSettings.RowCount = 4;
            tblpnlInitSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlInitSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlInitSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlInitSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlInitSettings.Size = new Size(1100, 1100);
            tblpnlInitSettings.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(numProblemCount, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 963);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1094, 64);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Microsoft YaHei UI", 12F);
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(194, 64);
            lbl1.TabIndex = 0;
            lbl1.Text = "题目数量";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numProblemCount
            // 
            numProblemCount.AutoSize = true;
            numProblemCount.Dock = DockStyle.Fill;
            numProblemCount.Font = new Font("微软雅黑", 12F);
            numProblemCount.Location = new Point(204, 5);
            numProblemCount.Margin = new Padding(4, 5, 4, 5);
            numProblemCount.Minimum = 3;
            numProblemCount.MinimumSize = new Size(100, 0);
            numProblemCount.Name = "numProblemCount";
            numProblemCount.ShowText = false;
            numProblemCount.Size = new Size(886, 54);
            numProblemCount.TabIndex = 1;
            numProblemCount.Text = "uiIntegerUpDown1";
            numProblemCount.TextAlignment = ContentAlignment.MiddleCenter;
            numProblemCount.Value = 3;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Dock = DockStyle.Fill;
            lblMode.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblMode.Location = new Point(3, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(1094, 70);
            lblMode.TabIndex = 1;
            lblMode.Text = "MODE ZONE";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("微软雅黑", 12F);
            btnStart.Location = new Point(3, 1033);
            btnStart.MinimumSize = new Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(1094, 64);
            btnStart.TabIndex = 3;
            btnStart.Text = "开始";
            btnStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStart.Click += btnStart_Click;
            // 
            // rtxtAlert
            // 
            rtxtAlert.Dock = DockStyle.Fill;
            rtxtAlert.Location = new Point(3, 73);
            rtxtAlert.Name = "rtxtAlert";
            rtxtAlert.ReadOnly = true;
            rtxtAlert.Size = new Size(1094, 884);
            rtxtAlert.TabIndex = 4;
            rtxtAlert.Text = "";
            // 
            // InitSettingsPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlInitSettings);
            Name = "InitSettingsPanel";
            Size = new Size(1100, 1100);
            Load += InitSettingsPanel_Load;
            tblpnlInitSettings.ResumeLayout(false);
            tblpnlInitSettings.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlInitSettings;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl1;
        private Sunny.UI.UIIntegerUpDown numProblemCount;
        private Label lblMode;
        private Sunny.UI.UIButton btnStart;
        private RichTextBox rtxtAlert;
    }
}
