namespace ChemistryBasics
{
    partial class RecordDialog
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
            tblpnlInput = new TableLayoutPanel();
            txtName = new Sunny.UI.UITextBox();
            lbl1 = new Label();
            tblpnlButtons = new TableLayoutPanel();
            btnDiscard = new Sunny.UI.UIButton();
            btnConfirm = new Sunny.UI.UIButton();
            tblpnlInput.SuspendLayout();
            tblpnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlInput
            // 
            tblpnlInput.ColumnCount = 1;
            tblpnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlInput.Controls.Add(txtName, 0, 1);
            tblpnlInput.Controls.Add(lbl1, 0, 0);
            tblpnlInput.Controls.Add(tblpnlButtons, 0, 2);
            tblpnlInput.Dock = DockStyle.Fill;
            tblpnlInput.Location = new Point(0, 50);
            tblpnlInput.Name = "tblpnlInput";
            tblpnlInput.RowCount = 3;
            tblpnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblpnlInput.Size = new Size(854, 335);
            tblpnlInput.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("微软雅黑", 18F);
            txtName.Location = new Point(4, 130);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.ShowText = false;
            txtName.Size = new Size(846, 75);
            txtName.TabIndex = 0;
            txtName.TextAlignment = ContentAlignment.MiddleCenter;
            txtName.Watermark = "";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(848, 70);
            lbl1.TabIndex = 2;
            lbl1.Text = "挑战成功！请输入你的姓名：";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblpnlButtons
            // 
            tblpnlButtons.ColumnCount = 3;
            tblpnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblpnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblpnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblpnlButtons.Controls.Add(btnDiscard, 0, 0);
            tblpnlButtons.Controls.Add(btnConfirm, 2, 0);
            tblpnlButtons.Dock = DockStyle.Fill;
            tblpnlButtons.Location = new Point(3, 268);
            tblpnlButtons.Name = "tblpnlButtons";
            tblpnlButtons.RowCount = 1;
            tblpnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlButtons.Size = new Size(848, 64);
            tblpnlButtons.TabIndex = 3;
            // 
            // btnDiscard
            // 
            btnDiscard.Dock = DockStyle.Fill;
            btnDiscard.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnDiscard.ForeColor = Color.DarkRed;
            btnDiscard.Location = new Point(3, 3);
            btnDiscard.MinimumSize = new Size(1, 1);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(375, 58);
            btnDiscard.TabIndex = 0;
            btnDiscard.Text = "放弃成绩";
            btnDiscard.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnConfirm.Location = new Point(468, 3);
            btnConfirm.MinimumSize = new Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(377, 58);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "确认成绩";
            btnConfirm.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnConfirm.Click += this.btnConfirm_Click;
            // 
            // RecordDialog
            // 
            AcceptButton = btnConfirm;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = btnDiscard;
            ClientSize = new Size(854, 385);
            Controls.Add(tblpnlInput);
            Font = new Font("微软雅黑", 12F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecordDialog";
            Padding = new Padding(0, 50, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "挑战成功！";
            TitleFont = new Font("微软雅黑", 10F);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            tblpnlInput.ResumeLayout(false);
            tblpnlInput.PerformLayout();
            tblpnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlInput;
        private Sunny.UI.UITextBox txtName;
        private Label lbl1;
        private TableLayoutPanel tblpnlButtons;
        private Sunny.UI.UIButton btnDiscard;
        private Sunny.UI.UIButton btnConfirm;
    }
}