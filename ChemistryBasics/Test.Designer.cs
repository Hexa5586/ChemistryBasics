namespace ChemistryBasics
{
    partial class Test
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
            uiLedStopwatch1 = new Sunny.UI.UILedStopwatch();
            SuspendLayout();
            // 
            // uiLedStopwatch1
            // 
            uiLedStopwatch1.BackColor = Color.Black;
            uiLedStopwatch1.ForeColor = Color.Lime;
            uiLedStopwatch1.IntervalOn = 4;
            uiLedStopwatch1.Location = new Point(587, 424);
            uiLedStopwatch1.Name = "uiLedStopwatch1";
            uiLedStopwatch1.ShowType = Sunny.UI.UILedStopwatch.TimeShowType.mmssfff;
            uiLedStopwatch1.Size = new Size(312, 48);
            uiLedStopwatch1.TabIndex = 0;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 975);
            Controls.Add(uiLedStopwatch1);
            Name = "Test";
            Text = "Test";
            Load += Test_Load;
            Click += Test_Click;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILedStopwatch uiLedStopwatch1;
    }
}