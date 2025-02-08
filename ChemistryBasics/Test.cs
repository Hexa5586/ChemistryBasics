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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            uiLedStopwatch1.Start();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            uiLedStopwatch1.Stop();
            MessageBox.Show(uiLedStopwatch1.TimeSpan.Milliseconds.ToString());
        }
    }
}
