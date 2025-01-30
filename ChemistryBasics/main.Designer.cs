namespace ChemistryBasics
{
    partial class main
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
            tbpnlMain = new TableLayoutPanel();
            tbpnlTab = new TableLayoutPanel();
            btnElementMode = new Sunny.UI.UIButton();
            btnFormulaMode = new Sunny.UI.UIButton();
            btnSettings = new Sunny.UI.UIButton();
            tbctrlMain = new TabControl();
            tbpElementMode = new TabPage();
            ElementPanel = new GamePanel();
            tbpFormulaMode = new TabPage();
            FormulaPanel = new GamePanel();
            tbpSettings = new TabPage();
            tbctrlSettings = new Sunny.UI.UITabControl();
            tbpElementQnAs = new TabPage();
            tblpnlElementQnAs = new TableLayoutPanel();
            lbl1 = new Label();
            txtElementQnAs = new Sunny.UI.UITextBox();
            btnElementSave = new Sunny.UI.UIButton();
            tbpFormulaQnAs = new TabPage();
            tblpnlFormulaQnAs = new TableLayoutPanel();
            btnFormulaSave = new Sunny.UI.UIButton();
            txtFormulaQnAs = new Sunny.UI.UITextBox();
            lbl2 = new Label();
            tbpAbout = new TabPage();
            tbpnlMain.SuspendLayout();
            tbpnlTab.SuspendLayout();
            tbctrlMain.SuspendLayout();
            tbpElementMode.SuspendLayout();
            tbpFormulaMode.SuspendLayout();
            tbpSettings.SuspendLayout();
            tbctrlSettings.SuspendLayout();
            tbpElementQnAs.SuspendLayout();
            tblpnlElementQnAs.SuspendLayout();
            tbpFormulaQnAs.SuspendLayout();
            tblpnlFormulaQnAs.SuspendLayout();
            SuspendLayout();
            // 
            // tbpnlMain
            // 
            tbpnlMain.ColumnCount = 2;
            tbpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tbpnlMain.Controls.Add(tbpnlTab, 0, 0);
            tbpnlMain.Controls.Add(tbctrlMain, 1, 0);
            tbpnlMain.Dock = DockStyle.Fill;
            tbpnlMain.Location = new Point(2, 50);
            tbpnlMain.Name = "tbpnlMain";
            tbpnlMain.RowCount = 1;
            tbpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbpnlMain.Size = new Size(1246, 948);
            tbpnlMain.TabIndex = 0;
            // 
            // tbpnlTab
            // 
            tbpnlTab.BackColor = SystemColors.ButtonFace;
            tbpnlTab.ColumnCount = 1;
            tbpnlTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbpnlTab.Controls.Add(btnElementMode, 0, 0);
            tbpnlTab.Controls.Add(btnFormulaMode, 0, 1);
            tbpnlTab.Controls.Add(btnSettings, 0, 2);
            tbpnlTab.Dock = DockStyle.Fill;
            tbpnlTab.Location = new Point(3, 3);
            tbpnlTab.Name = "tbpnlTab";
            tbpnlTab.RowCount = 4;
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle());
            tbpnlTab.Size = new Size(243, 942);
            tbpnlTab.TabIndex = 0;
            // 
            // btnElementMode
            // 
            btnElementMode.Dock = DockStyle.Fill;
            btnElementMode.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnElementMode.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnElementMode.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnElementMode.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnElementMode.Font = new Font("微软雅黑", 12F);
            btnElementMode.ForeColor = Color.Black;
            btnElementMode.ForeHoverColor = Color.Black;
            btnElementMode.ForePressColor = Color.Black;
            btnElementMode.ForeSelectedColor = Color.Black;
            btnElementMode.Location = new Point(3, 3);
            btnElementMode.MinimumSize = new Size(1, 1);
            btnElementMode.Name = "btnElementMode";
            btnElementMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnElementMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnElementMode.Size = new Size(237, 74);
            btnElementMode.TabIndex = 0;
            btnElementMode.Text = "元素符号";
            btnElementMode.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnElementMode.Click += TabButton_Click;
            // 
            // btnFormulaMode
            // 
            btnFormulaMode.Dock = DockStyle.Fill;
            btnFormulaMode.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnFormulaMode.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnFormulaMode.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnFormulaMode.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnFormulaMode.Font = new Font("微软雅黑", 12F);
            btnFormulaMode.ForeColor = Color.Black;
            btnFormulaMode.ForeHoverColor = Color.Black;
            btnFormulaMode.ForePressColor = Color.Black;
            btnFormulaMode.ForeSelectedColor = Color.Black;
            btnFormulaMode.Location = new Point(3, 83);
            btnFormulaMode.MinimumSize = new Size(1, 1);
            btnFormulaMode.Name = "btnFormulaMode";
            btnFormulaMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnFormulaMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnFormulaMode.Size = new Size(237, 74);
            btnFormulaMode.TabIndex = 1;
            btnFormulaMode.Text = "化学式";
            btnFormulaMode.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnFormulaMode.Click += TabButton_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnSettings.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnSettings.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnSettings.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnSettings.Font = new Font("微软雅黑", 12F);
            btnSettings.ForeColor = Color.Black;
            btnSettings.ForeHoverColor = Color.Black;
            btnSettings.ForePressColor = Color.Black;
            btnSettings.ForeSelectedColor = Color.Black;
            btnSettings.Location = new Point(3, 163);
            btnSettings.MinimumSize = new Size(1, 1);
            btnSettings.Name = "btnSettings";
            btnSettings.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnSettings.RectSides = ToolStripStatusLabelBorderSides.None;
            btnSettings.Size = new Size(237, 74);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "设置";
            btnSettings.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSettings.Click += TabButton_Click;
            // 
            // tbctrlMain
            // 
            tbctrlMain.Controls.Add(tbpElementMode);
            tbctrlMain.Controls.Add(tbpFormulaMode);
            tbctrlMain.Controls.Add(tbpSettings);
            tbctrlMain.Dock = DockStyle.Fill;
            tbctrlMain.Font = new Font("微软雅黑", 10F);
            tbctrlMain.ItemSize = new Size(150, 32);
            tbctrlMain.Location = new Point(252, 3);
            tbctrlMain.Multiline = true;
            tbctrlMain.Name = "tbctrlMain";
            tbctrlMain.SelectedIndex = 0;
            tbctrlMain.Size = new Size(991, 942);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
            tbctrlMain.TabIndex = 1;
            tbctrlMain.Visible = false;
            // 
            // tbpElementMode
            // 
            tbpElementMode.Controls.Add(ElementPanel);
            tbpElementMode.Location = new Point(4, 36);
            tbpElementMode.Name = "tbpElementMode";
            tbpElementMode.Padding = new Padding(3);
            tbpElementMode.Size = new Size(983, 902);
            tbpElementMode.TabIndex = 0;
            tbpElementMode.Text = "元素符号";
            tbpElementMode.UseVisualStyleBackColor = true;
            // 
            // ElementPanel
            // 
            ElementPanel.AnswerString = "";
            ElementPanel.CorrectAnswerCount = 0;
            ElementPanel.CorrectAnswerString = "";
            ElementPanel.Dock = DockStyle.Fill;
            ElementPanel.FinishedProblemCount = 0;
            ElementPanel.Location = new Point(3, 3);
            ElementPanel.Mode = 0;
            ElementPanel.Name = "ElementPanel";
            ElementPanel.QuestionString = "";
            ElementPanel.Size = new Size(977, 896);
            ElementPanel.TabIndex = 0;
            ElementPanel.TotalProblemCount = 0;
            ElementPanel.BtnSubmitClick += GamePanel_BtnSubmitClick;
            // 
            // tbpFormulaMode
            // 
            tbpFormulaMode.Controls.Add(FormulaPanel);
            tbpFormulaMode.Location = new Point(4, 36);
            tbpFormulaMode.Name = "tbpFormulaMode";
            tbpFormulaMode.Padding = new Padding(3);
            tbpFormulaMode.Size = new Size(983, 902);
            tbpFormulaMode.TabIndex = 1;
            tbpFormulaMode.Text = "化学式";
            tbpFormulaMode.UseVisualStyleBackColor = true;
            // 
            // FormulaPanel
            // 
            FormulaPanel.AnswerString = "";
            FormulaPanel.CorrectAnswerCount = 0;
            FormulaPanel.CorrectAnswerString = "";
            FormulaPanel.Dock = DockStyle.Fill;
            FormulaPanel.FinishedProblemCount = 0;
            FormulaPanel.Location = new Point(3, 3);
            FormulaPanel.Mode = 1;
            FormulaPanel.Name = "FormulaPanel";
            FormulaPanel.QuestionString = "";
            FormulaPanel.Size = new Size(977, 896);
            FormulaPanel.TabIndex = 0;
            FormulaPanel.TotalProblemCount = 0;
            FormulaPanel.BtnSubmitClick += GamePanel_BtnSubmitClick;
            // 
            // tbpSettings
            // 
            tbpSettings.Controls.Add(tbctrlSettings);
            tbpSettings.Location = new Point(4, 36);
            tbpSettings.Name = "tbpSettings";
            tbpSettings.Padding = new Padding(3);
            tbpSettings.Size = new Size(983, 902);
            tbpSettings.TabIndex = 2;
            tbpSettings.Text = "设置";
            tbpSettings.UseVisualStyleBackColor = true;
            // 
            // tbctrlSettings
            // 
            tbctrlSettings.Controls.Add(tbpElementQnAs);
            tbctrlSettings.Controls.Add(tbpFormulaQnAs);
            tbctrlSettings.Controls.Add(tbpAbout);
            tbctrlSettings.Dock = DockStyle.Fill;
            tbctrlSettings.DrawMode = TabDrawMode.OwnerDrawFixed;
            tbctrlSettings.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbctrlSettings.ItemSize = new Size(200, 40);
            tbctrlSettings.Location = new Point(3, 3);
            tbctrlSettings.MainPage = "";
            tbctrlSettings.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tbctrlSettings.Name = "tbctrlSettings";
            tbctrlSettings.SelectedIndex = 0;
            tbctrlSettings.Size = new Size(977, 896);
            tbctrlSettings.SizeMode = TabSizeMode.Fixed;
            tbctrlSettings.TabBackColor = Color.FromArgb(243, 249, 255);
            tbctrlSettings.TabIndex = 0;
            tbctrlSettings.TabSelectedColor = Color.FromArgb(80, 160, 255);
            tbctrlSettings.TabSelectedForeColor = Color.White;
            tbctrlSettings.TabSelectedHighColor = Color.FromArgb(150, 230, 255);
            tbctrlSettings.TabUnSelectedColor = Color.FromArgb(230, 230, 230);
            tbctrlSettings.TabUnSelectedForeColor = Color.Black;
            tbctrlSettings.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // tbpElementQnAs
            // 
            tbpElementQnAs.BackColor = Color.FromArgb(243, 249, 255);
            tbpElementQnAs.Controls.Add(tblpnlElementQnAs);
            tbpElementQnAs.Location = new Point(0, 40);
            tbpElementQnAs.Name = "tbpElementQnAs";
            tbpElementQnAs.Size = new Size(977, 856);
            tbpElementQnAs.TabIndex = 0;
            tbpElementQnAs.Text = "元素符号题库设定";
            // 
            // tblpnlElementQnAs
            // 
            tblpnlElementQnAs.ColumnCount = 1;
            tblpnlElementQnAs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlElementQnAs.Controls.Add(lbl1, 0, 0);
            tblpnlElementQnAs.Controls.Add(txtElementQnAs, 0, 1);
            tblpnlElementQnAs.Controls.Add(btnElementSave, 0, 2);
            tblpnlElementQnAs.Dock = DockStyle.Fill;
            tblpnlElementQnAs.Location = new Point(0, 0);
            tblpnlElementQnAs.Name = "tblpnlElementQnAs";
            tblpnlElementQnAs.RowCount = 3;
            tblpnlElementQnAs.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlElementQnAs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlElementQnAs.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlElementQnAs.Size = new Size(977, 856);
            tblpnlElementQnAs.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("微软雅黑", 12F);
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(971, 50);
            lbl1.TabIndex = 0;
            lbl1.Text = "元素符号题库设置（一行为一组，先输入问题后输入答案，用逗号分割）";
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtElementQnAs
            // 
            txtElementQnAs.Dock = DockStyle.Fill;
            txtElementQnAs.Font = new Font("微软雅黑", 12F);
            txtElementQnAs.Location = new Point(4, 55);
            txtElementQnAs.Margin = new Padding(4, 5, 4, 5);
            txtElementQnAs.MinimumSize = new Size(1, 16);
            txtElementQnAs.Multiline = true;
            txtElementQnAs.Name = "txtElementQnAs";
            txtElementQnAs.Padding = new Padding(15);
            txtElementQnAs.ScrollBarWidth = 5;
            txtElementQnAs.ShowScrollBar = true;
            txtElementQnAs.ShowText = false;
            txtElementQnAs.Size = new Size(969, 726);
            txtElementQnAs.TabIndex = 1;
            txtElementQnAs.TextAlignment = ContentAlignment.MiddleLeft;
            txtElementQnAs.Watermark = "";
            txtElementQnAs.TextChanged += txtElementQnAs_TextChanged;
            // 
            // btnElementSave
            // 
            btnElementSave.Dock = DockStyle.Fill;
            btnElementSave.Enabled = false;
            btnElementSave.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnElementSave.Location = new Point(3, 789);
            btnElementSave.MinimumSize = new Size(1, 1);
            btnElementSave.Name = "btnElementSave";
            btnElementSave.Size = new Size(971, 64);
            btnElementSave.TabIndex = 2;
            btnElementSave.Text = "保存更改";
            btnElementSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnElementSave.Click += btnElementSave_Click;
            // 
            // tbpFormulaQnAs
            // 
            tbpFormulaQnAs.BackColor = Color.FromArgb(243, 249, 255);
            tbpFormulaQnAs.Controls.Add(tblpnlFormulaQnAs);
            tbpFormulaQnAs.Location = new Point(0, 40);
            tbpFormulaQnAs.Name = "tbpFormulaQnAs";
            tbpFormulaQnAs.Size = new Size(200, 60);
            tbpFormulaQnAs.TabIndex = 1;
            tbpFormulaQnAs.Text = "化学式题库设定";
            // 
            // tblpnlFormulaQnAs
            // 
            tblpnlFormulaQnAs.ColumnCount = 1;
            tblpnlFormulaQnAs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlFormulaQnAs.Controls.Add(btnFormulaSave, 0, 2);
            tblpnlFormulaQnAs.Controls.Add(txtFormulaQnAs, 0, 1);
            tblpnlFormulaQnAs.Controls.Add(lbl2, 0, 0);
            tblpnlFormulaQnAs.Dock = DockStyle.Fill;
            tblpnlFormulaQnAs.Location = new Point(0, 0);
            tblpnlFormulaQnAs.Name = "tblpnlFormulaQnAs";
            tblpnlFormulaQnAs.RowCount = 3;
            tblpnlFormulaQnAs.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlFormulaQnAs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlFormulaQnAs.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlFormulaQnAs.Size = new Size(200, 60);
            tblpnlFormulaQnAs.TabIndex = 0;
            // 
            // btnFormulaSave
            // 
            btnFormulaSave.Dock = DockStyle.Fill;
            btnFormulaSave.Enabled = false;
            btnFormulaSave.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnFormulaSave.Location = new Point(3, -7);
            btnFormulaSave.MinimumSize = new Size(1, 1);
            btnFormulaSave.Name = "btnFormulaSave";
            btnFormulaSave.Size = new Size(194, 64);
            btnFormulaSave.TabIndex = 3;
            btnFormulaSave.Text = "保存更改";
            btnFormulaSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnFormulaSave.Click += btnFormulaSave_Click;
            // 
            // txtFormulaQnAs
            // 
            txtFormulaQnAs.Dock = DockStyle.Fill;
            txtFormulaQnAs.Font = new Font("微软雅黑", 12F);
            txtFormulaQnAs.Location = new Point(4, 55);
            txtFormulaQnAs.Margin = new Padding(4, 5, 4, 5);
            txtFormulaQnAs.MinimumSize = new Size(1, 16);
            txtFormulaQnAs.Multiline = true;
            txtFormulaQnAs.Name = "txtFormulaQnAs";
            txtFormulaQnAs.Padding = new Padding(15);
            txtFormulaQnAs.ShowScrollBar = true;
            txtFormulaQnAs.ShowText = false;
            txtFormulaQnAs.Size = new Size(192, 16);
            txtFormulaQnAs.TabIndex = 2;
            txtFormulaQnAs.TextAlignment = ContentAlignment.MiddleLeft;
            txtFormulaQnAs.Watermark = "";
            txtFormulaQnAs.TextChanged += txtFormulaQnAs_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("微软雅黑", 12F);
            lbl2.Location = new Point(3, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(194, 50);
            lbl2.TabIndex = 1;
            lbl2.Text = "元素符号题库设置（一行为一组，先输入问题后输入答案，用逗号分割）";
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbpAbout
            // 
            tbpAbout.BackColor = Color.FromArgb(243, 249, 255);
            tbpAbout.Location = new Point(0, 40);
            tbpAbout.Name = "tbpAbout";
            tbpAbout.Size = new Size(200, 60);
            tbpAbout.TabIndex = 2;
            tbpAbout.Text = "关于本软件";
            // 
            // main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1250, 1000);
            Controls.Add(tbpnlMain);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            MinimumSize = new Size(1250, 1000);
            Name = "main";
            Padding = new Padding(2, 50, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            Text = "化学符号默写大比拼";
            TitleFont = new Font("微软雅黑", 10F);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(15, 15, 794, 675);
            Load += main_Load;
            tbpnlMain.ResumeLayout(false);
            tbpnlTab.ResumeLayout(false);
            tbctrlMain.ResumeLayout(false);
            tbpElementMode.ResumeLayout(false);
            tbpFormulaMode.ResumeLayout(false);
            tbpSettings.ResumeLayout(false);
            tbctrlSettings.ResumeLayout(false);
            tbpElementQnAs.ResumeLayout(false);
            tblpnlElementQnAs.ResumeLayout(false);
            tblpnlElementQnAs.PerformLayout();
            tbpFormulaQnAs.ResumeLayout(false);
            tblpnlFormulaQnAs.ResumeLayout(false);
            tblpnlFormulaQnAs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tbpnlMain;
        private TableLayoutPanel tbpnlTab;
        private Sunny.UI.UIButton btnElementMode;
        private Sunny.UI.UIButton btnFormulaMode;
        private Sunny.UI.UIButton btnSettings;
        private TabControl tbctrlMain;
        private TabPage tbpElementMode;
        private TabPage tbpFormulaMode;
        private TabPage tbpSettings;
        private GamePanel ElementPanel;
        private GamePanel FormulaPanel;
        private Sunny.UI.UITabControl tbctrlSettings;
        private TabPage tbpElementQnAs;
        private TabPage tbpFormulaQnAs;
        private TabPage tbpAbout;
        private TableLayoutPanel tblpnlElementQnAs;
        private TableLayoutPanel tblpnlFormulaQnAs;
        private Label lbl1;
        private Sunny.UI.UIButton btnElementSave;
        private Sunny.UI.UITextBox txtFormulaQnAs;
        private Label lbl2;
        private Sunny.UI.UIButton btnFormulaSave;
        private Sunny.UI.UITextBox txtElementQnAs;
    }
}