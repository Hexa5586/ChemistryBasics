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
    public partial class GamePanel : UserControl
    {

        private int intTime = 0;
        private int intTotalProblemCnt = 0, intFinishedProblemCnt = 0, intCorrectProblemCnt = 0;
        private string strQuestion = "", strCorrectAnswer = "";
        private int mode;
        private int btnSubmitCounter = 0;
        private string[] btnSubmitDisplay = { "确认", "下一题" };

        public GamePanel()
        {
            InitializeComponent();
        }

        private void ElementModePanel_Load(object sender, EventArgs e)
        {
            this.Reset();
        }

        /// <summary>
        /// 事件
        /// </summary>
        public event EventHandler BtnSubmitClick;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BtnSubmitClick != null)
            {
                //TODO
                BtnSubmitClick(sender, e);
            }
            this.btnSubmit.Text = btnSubmitDisplay[(++btnSubmitCounter) % 2];

            FocusOnTextBox();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Mode == 1)
            {
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {
                    e.Handled = true;
                    int insert_index = this.txtAnswer.SelectionStart;
                    this.txtAnswer.Text = this.txtAnswer.Text.Insert(insert_index, "" + (char)(e.KeyChar - '0' + '\u2080'));
                    this.txtAnswer.SelectionStart = insert_index + 1;
                }

            }
        }

        public void Reset()
        {
            intTime = intTotalProblemCnt = intFinishedProblemCnt = intCorrectProblemCnt = 0;
            strQuestion = strCorrectAnswer = "";
            txtAnswer.Text = lblQuestion.Text = "";
        }

        public void FocusOnTextBox()
        {
            this.txtAnswer.Focus();
        }

        public void SetAnswerStatus(int status)
        {
            if (status == 0)
            {
                lblAnswerStatus.ForeColor = Color.Black;
                lblAnswerStatus.Text = "请作答";
                txtAnswer.FillColor = Color.White;
                tblpnlAnswer.BackColor = Color.White;
                txtAnswer.Text = "";
            }
            else if (status == 1)
            {
                lblAnswerStatus.ForeColor = Color.Green;
                lblAnswerStatus.Text = "恭喜你，答对了！";
                txtAnswer.FillColor = Color.LightGreen;
                tblpnlAnswer.BackColor = Color.LightGreen;
            }
            else
            {
                lblAnswerStatus.ForeColor = Color.Red;
                lblAnswerStatus.Text = "很遗憾，答错了。";
                txtAnswer.FillColor = Color.LightCoral;
                tblpnlAnswer.BackColor = Color.LightCoral;
                txtAnswer.Text = this.CorrectAnswerString;
            }
        }

        public bool IsAnswerCorrect()
        {
            return this.strCorrectAnswer.Trim() == this.txtAnswer.Text.Trim();
        }

        public string GetCurrentAccuracy()
        {
            if (intFinishedProblemCnt == 0)
            {
                return "100.00%";
            }
            double accuracy = intCorrectProblemCnt * 100.0 / intFinishedProblemCnt;
            return accuracy.ToString("F2") + "%";
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (BtnSubmitClick != null)
                {
                    BtnSubmitClick(sender, e);
                }
                FocusOnTextBox();
            }
        }

        private void GamePanel_Resize(object sender, EventArgs e)
        {
            this.lblQuestion.Font = new Font(this.lblQuestion.Font.FontFamily, (float)(this.tblpnlQuestion.Height * 1.0 / 96 * 18));
            this.txtAnswer.Font = new Font(this.txtAnswer.Font.FontFamily, (float)(this.tblpnlAnswer.Height * 1.0 / 96 * 16));
            this.txtAnswer.Height = (int)(this.tblpnlAnswer.Height);
        }

        [Browsable(true)]
        public int Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        public string QuestionString
        {
            get
            {
                return this.lblQuestion.Text;
            }

            set
            {
                strQuestion = value;
                this.lblQuestion.Text = value;
            }
        }

        public string AnswerString
        {
            get
            {
                return this.txtAnswer.Text;
            }

            set
            {
                this.txtAnswer.Text = value;
            }
        }

        public string CorrectAnswerString
        {
            get
            {
                return strCorrectAnswer;
            }
            set
            {
                char[] raw_answer = value.ToCharArray();
                for (int i = 0; i < raw_answer.Length; i++)
                {
                    if (char.IsDigit(raw_answer[i]))
                    {
                        raw_answer[i] = (char)(raw_answer[i] - '0' + '\u2080');
                    }
                }

                strCorrectAnswer = new string(raw_answer);
            }
        }

        public int TotalProblemCount
        {
            get
            {
                return intTotalProblemCnt;
            }
            set
            {
                intTotalProblemCnt = value;
                this.lblProgress.Text = intFinishedProblemCnt.ToString() + "/" + intTotalProblemCnt.ToString();
            }
        }

        public int FinishedProblemCount
        {
            get
            {
                return intFinishedProblemCnt;
            }

            set
            {
                intFinishedProblemCnt = value;
                this.lblProgress.Text = (intFinishedProblemCnt).ToString() + "/" + intTotalProblemCnt.ToString();
                this.lblAccuracy.Text = this.GetCurrentAccuracy();
            }
        }

        public int CorrectAnswerCount
        {
            get
            {
                return intCorrectProblemCnt;
            }

            set
            {
                intCorrectProblemCnt = value;
            }
        }

    }
}
