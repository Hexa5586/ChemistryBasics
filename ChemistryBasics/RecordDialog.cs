using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace ChemistryBasics
{
    public partial class RecordDialog : UIForm
    {
        public RecordDialog()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            return this.txtName.Text;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
