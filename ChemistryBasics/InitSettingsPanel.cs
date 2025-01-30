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

        string[] strModeNames = { "元素符号检测", "化学式检测", "化学方程式检测" };

        public InitSettingsPanel(int mode)
        {
            InitializeComponent();
            lblMode.Text = strModeNames[mode];
        }

        private void InitSettingsPanel_Load(object sender, EventArgs e)
        {
            
        }

        public EventHandler BtnStartClick;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(BtnStartClick != null)
            {
                BtnStartClick(this, e);
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
            }
        }
    }
}
