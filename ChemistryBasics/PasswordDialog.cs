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
    public partial class PasswordDialog : UIForm
    {
        private string strCorrectPsd = "";
        public PasswordDialog(string _psd)
        {
            InitializeComponent();
            strCorrectPsd = _psd;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != strCorrectPsd)
            {
                MessageBox.Show("管理员密码错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
