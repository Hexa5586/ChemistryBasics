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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            tblpnlMain = new TableLayoutPanel();
            tblpnlTab = new TableLayoutPanel();
            btnElementMode = new Sunny.UI.UIButton();
            btnFormulaMode = new Sunny.UI.UIButton();
            btnSettings = new Sunny.UI.UIButton();
            pictureBox1 = new PictureBox();
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
            tblpnlAbout = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tblpnlMain.SuspendLayout();
            tblpnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tbctrlMain.SuspendLayout();
            tbpElementMode.SuspendLayout();
            tbpFormulaMode.SuspendLayout();
            tbpSettings.SuspendLayout();
            tbctrlSettings.SuspendLayout();
            tbpElementQnAs.SuspendLayout();
            tblpnlElementQnAs.SuspendLayout();
            tbpFormulaQnAs.SuspendLayout();
            tblpnlFormulaQnAs.SuspendLayout();
            tbpAbout.SuspendLayout();
            tblpnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tblpnlMain
            // 
            tblpnlMain.ColumnCount = 2;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblpnlMain.Controls.Add(tblpnlTab, 0, 0);
            tblpnlMain.Controls.Add(tbctrlMain, 1, 0);
            tblpnlMain.Dock = DockStyle.Fill;
            tblpnlMain.Location = new Point(2, 50);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 1;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlMain.Size = new Size(1496, 1148);
            tblpnlMain.TabIndex = 0;
            // 
            // tblpnlTab
            // 
            tblpnlTab.BackColor = Color.FromArgb(220, 220, 240);
            tblpnlTab.ColumnCount = 1;
            tblpnlTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlTab.Controls.Add(btnElementMode, 0, 0);
            tblpnlTab.Controls.Add(btnFormulaMode, 0, 1);
            tblpnlTab.Controls.Add(btnSettings, 0, 2);
            tblpnlTab.Controls.Add(pictureBox1, 0, 4);
            tblpnlTab.Dock = DockStyle.Fill;
            tblpnlTab.Location = new Point(3, 3);
            tblpnlTab.Name = "tblpnlTab";
            tblpnlTab.RowCount = 6;
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 15.247818F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 15.247817F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 15.247817F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 26.0998688F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 26.0998688F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 2.0568068F));
            tblpnlTab.Size = new Size(368, 1142);
            tblpnlTab.TabIndex = 0;
            // 
            // btnElementMode
            // 
            btnElementMode.Dock = DockStyle.Fill;
            btnElementMode.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnElementMode.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnElementMode.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnElementMode.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnElementMode.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            btnElementMode.ForeColor = Color.FromArgb(21, 25, 198);
            btnElementMode.ForeHoverColor = Color.FromArgb(21, 25, 198);
            btnElementMode.ForePressColor = Color.FromArgb(21, 25, 198);
            btnElementMode.ForeSelectedColor = Color.Black;
            btnElementMode.Location = new Point(3, 3);
            btnElementMode.MinimumSize = new Size(1, 1);
            btnElementMode.Name = "btnElementMode";
            btnElementMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnElementMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnElementMode.Size = new Size(362, 168);
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
            btnFormulaMode.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            btnFormulaMode.ForeColor = Color.FromArgb(21, 25, 198);
            btnFormulaMode.ForeHoverColor = Color.FromArgb(21, 25, 198);
            btnFormulaMode.ForePressColor = Color.FromArgb(21, 25, 198);
            btnFormulaMode.ForeSelectedColor = Color.Black;
            btnFormulaMode.Location = new Point(3, 177);
            btnFormulaMode.MinimumSize = new Size(1, 1);
            btnFormulaMode.Name = "btnFormulaMode";
            btnFormulaMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnFormulaMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnFormulaMode.Size = new Size(362, 168);
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
            btnSettings.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(21, 25, 198);
            btnSettings.ForeHoverColor = Color.FromArgb(21, 25, 198);
            btnSettings.ForePressColor = Color.FromArgb(21, 25, 198);
            btnSettings.ForeSelectedColor = Color.Black;
            btnSettings.Location = new Point(3, 351);
            btnSettings.MinimumSize = new Size(1, 1);
            btnSettings.Name = "btnSettings";
            btnSettings.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnSettings.RectSides = ToolStripStatusLabelBorderSides.None;
            btnSettings.Size = new Size(362, 168);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "设置";
            btnSettings.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSettings.Click += TabButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 823);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tbctrlMain
            // 
            tbctrlMain.Controls.Add(tbpElementMode);
            tbctrlMain.Controls.Add(tbpFormulaMode);
            tbctrlMain.Controls.Add(tbpSettings);
            tbctrlMain.Dock = DockStyle.Fill;
            tbctrlMain.Font = new Font("微软雅黑", 10F);
            tbctrlMain.ItemSize = new Size(150, 32);
            tbctrlMain.Location = new Point(377, 3);
            tbctrlMain.Multiline = true;
            tbctrlMain.Name = "tbctrlMain";
            tbctrlMain.SelectedIndex = 0;
            tbctrlMain.Size = new Size(1116, 1142);
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
            tbpElementMode.Size = new Size(1108, 1102);
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
            ElementPanel.MinimumSize = new Size(1102, 1096);
            ElementPanel.Mode = 0;
            ElementPanel.Name = "ElementPanel";
            ElementPanel.QuestionString = "";
            ElementPanel.Size = new Size(1102, 1096);
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
            tbpFormulaMode.Size = new Size(1108, 1102);
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
            FormulaPanel.MinimumSize = new Size(1102, 1096);
            FormulaPanel.Mode = 1;
            FormulaPanel.Name = "FormulaPanel";
            FormulaPanel.QuestionString = "";
            FormulaPanel.Size = new Size(1102, 1096);
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
            tbpSettings.Size = new Size(1108, 1102);
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
            tbctrlSettings.Size = new Size(1102, 1096);
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
            tbpElementQnAs.Size = new Size(1102, 1056);
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
            tblpnlElementQnAs.Size = new Size(1102, 1056);
            tblpnlElementQnAs.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("微软雅黑", 12F);
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(1096, 50);
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
            txtElementQnAs.Size = new Size(1094, 926);
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
            btnElementSave.Location = new Point(3, 989);
            btnElementSave.MinimumSize = new Size(1, 1);
            btnElementSave.Name = "btnElementSave";
            btnElementSave.Size = new Size(1096, 64);
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
            tbpAbout.Controls.Add(tblpnlAbout);
            tbpAbout.Location = new Point(0, 40);
            tbpAbout.Name = "tbpAbout";
            tbpAbout.Size = new Size(200, 60);
            tbpAbout.TabIndex = 2;
            tbpAbout.Text = "关于本软件";
            // 
            // tblpnlAbout
            // 
            tblpnlAbout.ColumnCount = 3;
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblpnlAbout.Controls.Add(pictureBox2, 1, 0);
            tblpnlAbout.Controls.Add(label1, 1, 1);
            tblpnlAbout.Dock = DockStyle.Fill;
            tblpnlAbout.Location = new Point(0, 0);
            tblpnlAbout.Name = "tblpnlAbout";
            tblpnlAbout.RowCount = 3;
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblpnlAbout.Size = new Size(200, 60);
            tblpnlAbout.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("微软雅黑", 20F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "化学符号默写大比拼\r\nVer 1.0\r\nPowered By Microsoft .NET Framework 8.0\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1500, 1200);
            Controls.Add(tblpnlMain);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1500, 1200);
            Name = "main";
            Padding = new Padding(2, 50, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            Text = "化学符号默写大比拼";
            TitleFont = new Font("微软雅黑", 10F);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(15, 15, 794, 675);
            Load += main_Load;
            Resize += main_Resize;
            tblpnlMain.ResumeLayout(false);
            tblpnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            tbpAbout.ResumeLayout(false);
            tblpnlAbout.ResumeLayout(false);
            tblpnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblpnlMain;
        private TableLayoutPanel tblpnlTab;
        private Sunny.UI.UIButton btnElementMode;
        private Sunny.UI.UIButton btnFormulaMode;
        private Sunny.UI.UIButton btnSettings;
        private TabControl tbctrlMain;
        private TabPage tbpElementMode;
        private TabPage tbpFormulaMode;
        private TabPage tbpSettings;
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
        private PictureBox pictureBox1;
        private TableLayoutPanel tblpnlAbout;
        private PictureBox pictureBox2;
        private Label label1;
        private GamePanel ElementPanel;
        private GamePanel FormulaPanel;
    }
}