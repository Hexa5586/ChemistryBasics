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
            btnEquationMode = new Sunny.UI.UIButton();
            tbctrlMain = new TabControl();
            tabpElementMode = new TabPage();
            ElementPanel = new GamePanel();
            tabpFormulaMode = new TabPage();
            tabpEquationMode = new TabPage();
            EquationPanel = new GamePanel();
            FormulaPanel = new GamePanel();
            tbpnlMain.SuspendLayout();
            tbpnlTab.SuspendLayout();
            tbctrlMain.SuspendLayout();
            tabpElementMode.SuspendLayout();
            tabpFormulaMode.SuspendLayout();
            tabpEquationMode.SuspendLayout();
            SuspendLayout();
            // 
            // tbpnlMain
            // 
            tbpnlMain.ColumnCount = 2;
            tbpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tbpnlMain.ColumnStyles.Add(new ColumnStyle());
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
            tbpnlTab.BackColor = Color.FromArgb(230, 230, 230);
            tbpnlTab.ColumnCount = 1;
            tbpnlTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbpnlTab.Controls.Add(btnElementMode, 0, 0);
            tbpnlTab.Controls.Add(btnFormulaMode, 0, 1);
            tbpnlTab.Controls.Add(btnEquationMode, 0, 2);
            tbpnlTab.Dock = DockStyle.Fill;
            tbpnlTab.Location = new Point(3, 3);
            tbpnlTab.Name = "tbpnlTab";
            tbpnlTab.RowCount = 4;
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpnlTab.RowStyles.Add(new RowStyle());
            tbpnlTab.Size = new Size(244, 942);
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
            btnElementMode.Size = new Size(238, 74);
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
            btnFormulaMode.Size = new Size(238, 74);
            btnFormulaMode.TabIndex = 1;
            btnFormulaMode.Text = "化学式";
            btnFormulaMode.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnFormulaMode.Click += TabButton_Click;
            // 
            // btnEquationMode
            // 
            btnEquationMode.Dock = DockStyle.Fill;
            btnEquationMode.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnEquationMode.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnEquationMode.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnEquationMode.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnEquationMode.Font = new Font("微软雅黑", 12F);
            btnEquationMode.ForeColor = Color.Black;
            btnEquationMode.ForeHoverColor = Color.Black;
            btnEquationMode.ForePressColor = Color.Black;
            btnEquationMode.ForeSelectedColor = Color.Black;
            btnEquationMode.Location = new Point(3, 163);
            btnEquationMode.MinimumSize = new Size(1, 1);
            btnEquationMode.Name = "btnEquationMode";
            btnEquationMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnEquationMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnEquationMode.Size = new Size(238, 74);
            btnEquationMode.TabIndex = 2;
            btnEquationMode.Text = "化学方程式";
            btnEquationMode.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnEquationMode.Click += TabButton_Click;
            // 
            // tbctrlMain
            // 
            tbctrlMain.Controls.Add(tabpElementMode);
            tbctrlMain.Controls.Add(tabpFormulaMode);
            tbctrlMain.Controls.Add(tabpEquationMode);
            tbctrlMain.Dock = DockStyle.Fill;
            tbctrlMain.Font = new Font("微软雅黑", 10F);
            tbctrlMain.ItemSize = new Size(0, 32);
            tbctrlMain.Location = new Point(253, 3);
            tbctrlMain.Multiline = true;
            tbctrlMain.Name = "tbctrlMain";
            tbctrlMain.SelectedIndex = 0;
            tbctrlMain.Size = new Size(990, 942);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
            tbctrlMain.TabIndex = 1;
            tbctrlMain.Visible = false;
            // 
            // tabpElementMode
            // 
            tabpElementMode.Controls.Add(ElementPanel);
            tabpElementMode.Location = new Point(4, 36);
            tabpElementMode.Name = "tabpElementMode";
            tabpElementMode.Padding = new Padding(3);
            tabpElementMode.Size = new Size(982, 902);
            tabpElementMode.TabIndex = 0;
            tabpElementMode.Text = "元素符号";
            tabpElementMode.UseVisualStyleBackColor = true;
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
            ElementPanel.Size = new Size(976, 896);
            ElementPanel.TabIndex = 0;
            ElementPanel.TotalProblemCount = 0;
            ElementPanel.BtnSubmitClick += elementModePanel_BtnSubmitClick;
            // 
            // tabpFormulaMode
            // 
            tabpFormulaMode.Controls.Add(FormulaPanel);
            tabpFormulaMode.Location = new Point(4, 36);
            tabpFormulaMode.Name = "tabpFormulaMode";
            tabpFormulaMode.Padding = new Padding(3);
            tabpFormulaMode.Size = new Size(982, 902);
            tabpFormulaMode.TabIndex = 1;
            tabpFormulaMode.Text = "化学式";
            tabpFormulaMode.UseVisualStyleBackColor = true;
            // 
            // tabpEquationMode
            // 
            tabpEquationMode.Controls.Add(EquationPanel);
            tabpEquationMode.Location = new Point(4, 36);
            tabpEquationMode.Name = "tabpEquationMode";
            tabpEquationMode.Padding = new Padding(3);
            tabpEquationMode.Size = new Size(982, 902);
            tabpEquationMode.TabIndex = 2;
            tabpEquationMode.Text = "化学方程式";
            tabpEquationMode.UseVisualStyleBackColor = true;
            // 
            // EquationPanel
            // 
            EquationPanel.AnswerString = "";
            EquationPanel.CorrectAnswerCount = 0;
            EquationPanel.CorrectAnswerString = "";
            EquationPanel.Dock = DockStyle.Fill;
            EquationPanel.FinishedProblemCount = 0;
            EquationPanel.Location = new Point(3, 3);
            EquationPanel.Mode = 2;
            EquationPanel.Name = "EquationPanel";
            EquationPanel.QuestionString = "";
            EquationPanel.Size = new Size(976, 896);
            EquationPanel.TabIndex = 0;
            EquationPanel.TotalProblemCount = 0;
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
            FormulaPanel.Size = new Size(976, 896);
            FormulaPanel.TabIndex = 0;
            FormulaPanel.TotalProblemCount = 0;
            // 
            // main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1250, 1000);
            Controls.Add(tbpnlMain);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            MinimumSize = new Size(1250, 1000);
            Name = "main";
            Padding = new Padding(2, 50, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            Text = "化学基础大比拼";
            TitleFont = new Font("微软雅黑", 10F);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(15, 15, 794, 675);
            Load += main_Load;
            tbpnlMain.ResumeLayout(false);
            tbpnlTab.ResumeLayout(false);
            tbctrlMain.ResumeLayout(false);
            tabpElementMode.ResumeLayout(false);
            tabpFormulaMode.ResumeLayout(false);
            tabpEquationMode.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tbpnlMain;
        private TableLayoutPanel tbpnlTab;
        private Sunny.UI.UIButton btnElementMode;
        private Sunny.UI.UIButton btnFormulaMode;
        private Sunny.UI.UIButton btnEquationMode;
        private TabControl tbctrlMain;
        private TabPage tabpElementMode;
        private TabPage tabpFormulaMode;
        private TabPage tabpEquationMode;
        private GamePanel ElementPanel;
        private GamePanel FormulaPanel;
        private GamePanel EquationPanel;
    }
}