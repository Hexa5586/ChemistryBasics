using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryBasics
{
    public partial class InitSettingsPanel : UserControl
    {

        private readonly string[] strModeNames = { "元素符号默写大比拼", "化学式默写大比拼", "元素符号默写完美挑战", "化学式默写完美挑战" };
        public const int intPerfectChallengeProblemCount = 20;
        private int intMode;
        public EventHandler? BtnStartClick;

        public InitSettingsPanel(int mode)
        {
            InitializeComponent();
            
            lblMode.Text = strModeNames[mode];
            intMode = mode;
            if (mode == 2 || mode == 3)
            {
                numProblemCount.Enabled = false;
                numProblemCount.Value = intPerfectChallengeProblemCount;
            }
        }

        private void InitSettingsPanel_Load(object sender, EventArgs e)
        {
            if(intMode == 2 || intMode == 3)
            {
                btnStart.Focus();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (BtnStartClick != null)
            {
                BtnStartClick(this, EventArgs.Empty);
            }
        }


        public string? AlertString
        {
            get
            {
                return rtxtAlert.Rtf;
            }
            set
            {
                rtxtAlert.Rtf = value;
            }
        }

        public int TotalProblemCount
        {
            get
            {
                return numProblemCount.Value;
            }

        }

        public int MaximumCount
        {
            get
            {
                return this.numProblemCount.Maximum;
            }

            set
            {
                this.numProblemCount.Maximum = value;
                this.numProblemCount.Value = Math.Min(this.numProblemCount.Value, this.numProblemCount.Maximum);
            }
        }
    }
}
