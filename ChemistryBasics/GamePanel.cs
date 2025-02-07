using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryBasics
{
    public partial class GamePanel : UserControl
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        private int intTime = 0;
        private int intTotalProblemCnt = 0, intFinishedProblemCnt = 0, intCorrectProblemCnt = 0;
        private string strQuestion = "", strCorrectAnswer = "";
        private int mode;
        private int btnSubmitCounter = 0;
        private string[] btnSubmitDisplay = { "确认", "下一题" };
        private Dictionary<Control, float> initialFontSizes = new Dictionary<Control, float>();
        public event EventHandler? BtnSubmitClick;

        public List<Tuple<string, string, string>> errors = new List<Tuple<string, string, string>>();

        public GamePanel()
        {
            InitializeComponent();
            try
            {
                pfc.AddFontFile("calibrib.ttf");
            }
            catch (Exception)
            {
                ;
            }
        }

        private void ElementModePanel_Load(object sender, EventArgs e)
        {
            this.Reset();
            try
            {
                txtAnswer.Font = new Font(pfc.Families[0], txtAnswer.Font.Size, txtAnswer.Font.Style);
            }
            catch (Exception)
            {
                ;
            }
            
        }

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

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (btnSubmit.Enabled && BtnSubmitClick != null)
                {
                    BtnSubmitClick(sender, e);
                }
                FocusOnTextBox();
            }
        }

        private void GamePanel_Resize(object sender, EventArgs e)
        {
            ScaleFonts(this);
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }

        private void RecordInitialFontSizes(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                // 记录当前控件的初始字体大小
                initialFontSizes[childControl] = childControl.Font.Size;

                // 递归处理子控件
                if (childControl.Controls.Count > 0)
                {
                    RecordInitialFontSizes(childControl);
                }
            }
        }

        private void ScaleFonts(Control control)
        {
            // 计算缩放比例（基于窗体宽度或高度的变化）
            float scaleFactor = Math.Min(
                (float)this.Width / this.MinimumSize.Width,
                (float)this.Height / this.MinimumSize.Height
            );

            List<Control> controls = new List<Control> { txtQuestion, txtAnswer };
            foreach (Control childControl in controls)
            {
                if (initialFontSizes.ContainsKey(childControl))
                {
                    // 根据初始字体大小和缩放比例计算新字体大小
                    float initialSize = initialFontSizes[childControl];
                    float newSize = initialSize * scaleFactor;

                    // 设置新字体大小
                    childControl.Font = new Font(childControl.Font.FontFamily, newSize, childControl.Font.Style);
                }

            }
        }
        public void Reset()
        {
            intTime = intTotalProblemCnt = intFinishedProblemCnt = intCorrectProblemCnt = 0;
            strQuestion = strCorrectAnswer = "";
            txtAnswer.Text = txtQuestion.Text = "";

            errors.Clear();

            RecordInitialFontSizes(this);
        }

        public void RecordAsError()
        {
            errors.Add(new Tuple<string, string, string>(QuestionString, CorrectAnswerString, AnswerString));
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

        public double GetCurrentAccuracy()
        {
            if (intFinishedProblemCnt == 0)
            {
                return 100.00;
            }
            double accuracy = intCorrectProblemCnt * 100.0 / intFinishedProblemCnt;
            return Math.Round(accuracy, 2);
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
                return this.txtQuestion.Text;
            }

            set
            {
                strQuestion = value;
                this.txtQuestion.Text = value;
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
                this.lblAccuracy.Text = this.GetCurrentAccuracy().ToString("F1") + "%";
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
