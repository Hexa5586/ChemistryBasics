namespace ChemistryBasics
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tblpnlMain = new TableLayoutPanel();
            tbctrlMain = new TabControl();
            tbpElementMode = new TabPage();
            tbpFormulaMode = new TabPage();
            tbpPerfectChallenge = new TabPage();
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
            tbpAuthenticate = new TabPage();
            tblpnlAbout = new TableLayoutPanel();
            tblpnlOldPassword = new TableLayoutPanel();
            lbl3 = new Label();
            txtOldPassword = new Sunny.UI.UITextBox();
            tblpnlNewPassword = new TableLayoutPanel();
            lbl4 = new Label();
            txtNewPassword = new Sunny.UI.UITextBox();
            btnPasswordConfirm = new Sunny.UI.UIButton();
            lbl5 = new Label();
            tbpAbout = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            picIcon = new PictureBox();
            lbl6 = new Label();
            tblpnlTab = new TableLayoutPanel();
            btnSettings = new Sunny.UI.UIButton();
            btnElementMode = new Sunny.UI.UIButton();
            btnFormulaMode = new Sunny.UI.UIButton();
            btnPerfectChallenge = new Sunny.UI.UIButton();
            picAccessory = new PictureBox();
            tblpnlMain.SuspendLayout();
            tbctrlMain.SuspendLayout();
            tbpSettings.SuspendLayout();
            tbctrlSettings.SuspendLayout();
            tbpElementQnAs.SuspendLayout();
            tblpnlElementQnAs.SuspendLayout();
            tbpFormulaQnAs.SuspendLayout();
            tblpnlFormulaQnAs.SuspendLayout();
            tbpAuthenticate.SuspendLayout();
            tblpnlAbout.SuspendLayout();
            tblpnlOldPassword.SuspendLayout();
            tblpnlNewPassword.SuspendLayout();
            tbpAbout.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            tblpnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAccessory).BeginInit();
            SuspendLayout();
            // 
            // tblpnlMain
            // 
            tblpnlMain.ColumnCount = 2;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblpnlMain.Controls.Add(tbctrlMain, 1, 0);
            tblpnlMain.Controls.Add(tblpnlTab, 0, 0);
            tblpnlMain.Dock = DockStyle.Fill;
            tblpnlMain.Location = new Point(2, 50);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 1;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlMain.Size = new Size(1246, 948);
            tblpnlMain.TabIndex = 0;
            // 
            // tbctrlMain
            // 
            tbctrlMain.Controls.Add(tbpElementMode);
            tbctrlMain.Controls.Add(tbpFormulaMode);
            tbctrlMain.Controls.Add(tbpPerfectChallenge);
            tbctrlMain.Controls.Add(tbpSettings);
            tbctrlMain.Dock = DockStyle.Fill;
            tbctrlMain.Font = new Font("微软雅黑", 10F);
            tbctrlMain.ItemSize = new Size(150, 32);
            tbctrlMain.Location = new Point(314, 3);
            tbctrlMain.Multiline = true;
            tbctrlMain.Name = "tbctrlMain";
            tbctrlMain.SelectedIndex = 0;
            tbctrlMain.Size = new Size(929, 942);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
            tbctrlMain.TabIndex = 2;
            tbctrlMain.Visible = false;
            // 
            // tbpElementMode
            // 
            tbpElementMode.Location = new Point(4, 36);
            tbpElementMode.Name = "tbpElementMode";
            tbpElementMode.Padding = new Padding(3);
            tbpElementMode.Size = new Size(921, 902);
            tbpElementMode.TabIndex = 0;
            tbpElementMode.Text = "元素符号";
            tbpElementMode.UseVisualStyleBackColor = true;
            // 
            // tbpFormulaMode
            // 
            tbpFormulaMode.Location = new Point(4, 36);
            tbpFormulaMode.Name = "tbpFormulaMode";
            tbpFormulaMode.Padding = new Padding(3);
            tbpFormulaMode.Size = new Size(1108, 1102);
            tbpFormulaMode.TabIndex = 1;
            tbpFormulaMode.Text = "化学式";
            tbpFormulaMode.UseVisualStyleBackColor = true;
            // 
            // tbpPerfectChallenge
            // 
            tbpPerfectChallenge.Location = new Point(4, 36);
            tbpPerfectChallenge.Name = "tbpPerfectChallenge";
            tbpPerfectChallenge.Size = new Size(1108, 1102);
            tbpPerfectChallenge.TabIndex = 3;
            tbpPerfectChallenge.Text = "完美挑战";
            tbpPerfectChallenge.UseVisualStyleBackColor = true;
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
            tbctrlSettings.Controls.Add(tbpAuthenticate);
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
            btnElementSave.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
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
            btnFormulaSave.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
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
            lbl2.Text = "化学式题库设置（一行为一组，先输入问题后输入答案，用逗号分割）";
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbpAuthenticate
            // 
            tbpAuthenticate.BackColor = Color.FromArgb(243, 249, 255);
            tbpAuthenticate.Controls.Add(tblpnlAbout);
            tbpAuthenticate.Location = new Point(0, 40);
            tbpAuthenticate.Name = "tbpAuthenticate";
            tbpAuthenticate.Size = new Size(200, 60);
            tbpAuthenticate.TabIndex = 2;
            tbpAuthenticate.Text = "管理员设定";
            // 
            // tblpnlAbout
            // 
            tblpnlAbout.ColumnCount = 3;
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tblpnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblpnlAbout.Controls.Add(tblpnlOldPassword, 1, 1);
            tblpnlAbout.Controls.Add(tblpnlNewPassword, 1, 2);
            tblpnlAbout.Controls.Add(btnPasswordConfirm, 1, 3);
            tblpnlAbout.Controls.Add(lbl5, 1, 0);
            tblpnlAbout.Dock = DockStyle.Fill;
            tblpnlAbout.Location = new Point(0, 0);
            tblpnlAbout.Name = "tblpnlAbout";
            tblpnlAbout.RowCount = 5;
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlAbout.Size = new Size(200, 60);
            tblpnlAbout.TabIndex = 0;
            // 
            // tblpnlOldPassword
            // 
            tblpnlOldPassword.ColumnCount = 2;
            tblpnlOldPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tblpnlOldPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlOldPassword.Controls.Add(lbl3, 0, 0);
            tblpnlOldPassword.Controls.Add(txtOldPassword, 1, 0);
            tblpnlOldPassword.Dock = DockStyle.Fill;
            tblpnlOldPassword.Location = new Point(31, 73);
            tblpnlOldPassword.Name = "tblpnlOldPassword";
            tblpnlOldPassword.RowCount = 1;
            tblpnlOldPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlOldPassword.Size = new Size(136, 64);
            tblpnlOldPassword.TabIndex = 3;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("微软雅黑", 10.5F, FontStyle.Bold);
            lbl3.Location = new Point(3, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(204, 64);
            lbl3.TabIndex = 0;
            lbl3.Text = "旧密码";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Dock = DockStyle.Fill;
            txtOldPassword.Font = new Font("微软雅黑", 12F);
            txtOldPassword.Location = new Point(214, 5);
            txtOldPassword.Margin = new Padding(4, 5, 4, 5);
            txtOldPassword.MinimumSize = new Size(1, 16);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Padding = new Padding(5);
            txtOldPassword.PasswordChar = '●';
            txtOldPassword.ShowText = false;
            txtOldPassword.Size = new Size(1, 54);
            txtOldPassword.TabIndex = 1;
            txtOldPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtOldPassword.Watermark = "";
            // 
            // tblpnlNewPassword
            // 
            tblpnlNewPassword.ColumnCount = 2;
            tblpnlNewPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tblpnlNewPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlNewPassword.Controls.Add(lbl4, 0, 0);
            tblpnlNewPassword.Controls.Add(txtNewPassword, 1, 0);
            tblpnlNewPassword.Dock = DockStyle.Fill;
            tblpnlNewPassword.Location = new Point(31, 143);
            tblpnlNewPassword.Name = "tblpnlNewPassword";
            tblpnlNewPassword.RowCount = 1;
            tblpnlNewPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlNewPassword.Size = new Size(136, 64);
            tblpnlNewPassword.TabIndex = 4;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("微软雅黑", 10.5F, FontStyle.Bold);
            lbl4.Location = new Point(3, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(204, 64);
            lbl4.TabIndex = 0;
            lbl4.Text = "新密码";
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Dock = DockStyle.Fill;
            txtNewPassword.Font = new Font("微软雅黑", 12F);
            txtNewPassword.Location = new Point(214, 5);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.MinimumSize = new Size(1, 16);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Padding = new Padding(5);
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.ShowText = false;
            txtNewPassword.Size = new Size(1, 54);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPassword.Watermark = "";
            // 
            // btnPasswordConfirm
            // 
            btnPasswordConfirm.Dock = DockStyle.Fill;
            btnPasswordConfirm.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnPasswordConfirm.Location = new Point(31, 213);
            btnPasswordConfirm.MinimumSize = new Size(1, 1);
            btnPasswordConfirm.Name = "btnPasswordConfirm";
            btnPasswordConfirm.Size = new Size(136, 64);
            btnPasswordConfirm.TabIndex = 5;
            btnPasswordConfirm.Text = "确认更改";
            btnPasswordConfirm.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnPasswordConfirm.Click += btnPasswordConfirm_Click;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl5.Location = new Point(31, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(136, 70);
            lbl5.TabIndex = 6;
            lbl5.Text = "管理员密码设定";
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbpAbout
            // 
            tbpAbout.Controls.Add(tableLayoutPanel3);
            tbpAbout.Location = new Point(0, 40);
            tbpAbout.Name = "tbpAbout";
            tbpAbout.Size = new Size(200, 60);
            tbpAbout.TabIndex = 3;
            tbpAbout.Text = "关于";
            tbpAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(243, 249, 255);
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Controls.Add(picIcon, 1, 0);
            tableLayoutPanel3.Controls.Add(lbl6, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.Size = new Size(200, 60);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // picIcon
            // 
            picIcon.Dock = DockStyle.Fill;
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new Point(31, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(136, 9);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Dock = DockStyle.Fill;
            lbl6.Font = new Font("微软雅黑", 12F);
            lbl6.Location = new Point(31, 15);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(136, 45);
            lbl6.TabIndex = 1;
            lbl6.Text = "化学符号默写大比拼\r\nBeta 1.1\r\nPowered By Microsoft .NET Framework 8.0\r\n";
            lbl6.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblpnlTab
            // 
            tblpnlTab.BackColor = Color.FromArgb(220, 220, 240);
            tblpnlTab.ColumnCount = 1;
            tblpnlTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlTab.Controls.Add(btnSettings, 0, 3);
            tblpnlTab.Controls.Add(btnElementMode, 0, 0);
            tblpnlTab.Controls.Add(btnFormulaMode, 0, 1);
            tblpnlTab.Controls.Add(btnPerfectChallenge, 0, 2);
            tblpnlTab.Controls.Add(picAccessory, 0, 5);
            tblpnlTab.Dock = DockStyle.Fill;
            tblpnlTab.Location = new Point(3, 3);
            tblpnlTab.Name = "tblpnlTab";
            tblpnlTab.RowCount = 7;
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2302122F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 13.23021F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 13.23021F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2321043F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6463089F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 22.646307F));
            tblpnlTab.RowStyles.Add(new RowStyle(SizeType.Percent, 1.784648F));
            tblpnlTab.Size = new Size(305, 942);
            tblpnlTab.TabIndex = 0;
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
            btnSettings.Location = new Point(3, 375);
            btnSettings.MinimumSize = new Size(1, 1);
            btnSettings.Name = "btnSettings";
            btnSettings.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnSettings.RectSides = ToolStripStatusLabelBorderSides.None;
            btnSettings.Size = new Size(299, 118);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "设置";
            btnSettings.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSettings.Click += TabButton_Click;
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
            btnElementMode.Size = new Size(299, 118);
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
            btnFormulaMode.Location = new Point(3, 127);
            btnFormulaMode.MinimumSize = new Size(1, 1);
            btnFormulaMode.Name = "btnFormulaMode";
            btnFormulaMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnFormulaMode.RectSides = ToolStripStatusLabelBorderSides.None;
            btnFormulaMode.Size = new Size(299, 118);
            btnFormulaMode.TabIndex = 1;
            btnFormulaMode.Text = "化学式";
            btnFormulaMode.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnFormulaMode.Click += TabButton_Click;
            // 
            // btnPerfectChallenge
            // 
            btnPerfectChallenge.Dock = DockStyle.Fill;
            btnPerfectChallenge.FillColor = Color.FromArgb(0, 0, 0, 0);
            btnPerfectChallenge.FillHoverColor = Color.FromArgb(50, 0, 0, 0);
            btnPerfectChallenge.FillPressColor = Color.FromArgb(100, 0, 0, 0);
            btnPerfectChallenge.FillSelectedColor = Color.FromArgb(50, 0, 0, 0);
            btnPerfectChallenge.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            btnPerfectChallenge.ForeColor = Color.FromArgb(21, 25, 198);
            btnPerfectChallenge.ForeHoverColor = Color.FromArgb(21, 25, 198);
            btnPerfectChallenge.ForePressColor = Color.FromArgb(21, 25, 198);
            btnPerfectChallenge.ForeSelectedColor = Color.Black;
            btnPerfectChallenge.Location = new Point(3, 251);
            btnPerfectChallenge.MinimumSize = new Size(1, 1);
            btnPerfectChallenge.Name = "btnPerfectChallenge";
            btnPerfectChallenge.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnPerfectChallenge.RectSides = ToolStripStatusLabelBorderSides.None;
            btnPerfectChallenge.Size = new Size(299, 118);
            btnPerfectChallenge.TabIndex = 2;
            btnPerfectChallenge.Text = "完美挑战";
            btnPerfectChallenge.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnPerfectChallenge.Click += TabButton_Click;
            // 
            // picAccessory
            // 
            picAccessory.Dock = DockStyle.Fill;
            picAccessory.Image = (Image)resources.GetObject("picAccessory.Image");
            picAccessory.Location = new Point(3, 712);
            picAccessory.Name = "picAccessory";
            picAccessory.Size = new Size(299, 207);
            picAccessory.SizeMode = PictureBoxSizeMode.Zoom;
            picAccessory.TabIndex = 4;
            picAccessory.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1250, 1000);
            Controls.Add(tblpnlMain);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1250, 1000);
            Name = "MainWindow";
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
            tbctrlMain.ResumeLayout(false);
            tbpSettings.ResumeLayout(false);
            tbctrlSettings.ResumeLayout(false);
            tbpElementQnAs.ResumeLayout(false);
            tblpnlElementQnAs.ResumeLayout(false);
            tblpnlElementQnAs.PerformLayout();
            tbpFormulaQnAs.ResumeLayout(false);
            tblpnlFormulaQnAs.ResumeLayout(false);
            tblpnlFormulaQnAs.PerformLayout();
            tbpAuthenticate.ResumeLayout(false);
            tblpnlAbout.ResumeLayout(false);
            tblpnlAbout.PerformLayout();
            tblpnlOldPassword.ResumeLayout(false);
            tblpnlOldPassword.PerformLayout();
            tblpnlNewPassword.ResumeLayout(false);
            tblpnlNewPassword.PerformLayout();
            tbpAbout.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            tblpnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAccessory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblpnlMain;
        private TableLayoutPanel tblpnlTab;
        private Sunny.UI.UIButton btnElementMode;
        private Sunny.UI.UIButton btnFormulaMode;
        private Sunny.UI.UIButton btnPerfectChallenge;
        private PictureBox picAccessory;
        private TabControl tbctrlMain;
        private TabPage tbpElementMode;
        private TabPage tbpFormulaMode;
        private TabPage tbpSettings;
        private Sunny.UI.UITabControl tbctrlSettings;
        private TabPage tbpElementQnAs;
        private TableLayoutPanel tblpnlElementQnAs;
        private Label lbl1;
        private Sunny.UI.UITextBox txtElementQnAs;
        private Sunny.UI.UIButton btnElementSave;
        private TabPage tbpFormulaQnAs;
        private TableLayoutPanel tblpnlFormulaQnAs;
        private Sunny.UI.UIButton btnFormulaSave;
        private Sunny.UI.UITextBox txtFormulaQnAs;
        private Label lbl2;
        private TabPage tbpAuthenticate;
        private TableLayoutPanel tblpnlAbout;
        private Label lbl5;
        private Sunny.UI.UIButton btnSettings;
        private TabPage tbpPerfectChallenge;
        private TableLayoutPanel tblpnlOldPassword;
        private TableLayoutPanel tblpnlNewPassword;
        private Label lbl3;
        private Sunny.UI.UITextBox txtOldPassword;
        private Label lbl4;
        private Sunny.UI.UITextBox txtNewPassword;
        private Sunny.UI.UIButton btnPasswordConfirm;
        private TabPage tbpAbout;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox picIcon;
        private Label lbl6;
    }
}