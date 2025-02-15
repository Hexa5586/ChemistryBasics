﻿using System;
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
    public partial class PerfectGamePanel : UserControl
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        private int intTime = 0;
        private int intTotalProblemCnt = 0, intFinishedProblemCnt = 0;
        private string strQuestion = "", strCorrectAnswer = "";
        private int intMode;
        private int btnSubmitCounter = 0;
        private readonly string[] btnSubmitDisplay = { "确认", "下一题" };
        private Dictionary<Control, float> initialFontSizes = new Dictionary<Control, float>();
        public event EventHandler? BtnSubmitClick;

        public List<Tuple<string, string, string>> errors = new List<Tuple<string, string, string>>();

        public PerfectGamePanel(int mode = 0)
        {
            InitializeComponent();
            
            this.Mode = mode;
            try
            {
                pfc.AddFontFile("calibrib.ttf");
            }
            catch (Exception)
            {
                ;
            }
        }

        public void TimerStart()
        {
            this.chronoTimer.Start();
        }

        public void TimerStop()
        {
            this.chronoTimer.Stop();
        }

        private void PerfectChallengeGamePanel_Load(object sender, EventArgs e)
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
            int IntervalOn_Width = (chronoTimer.Width - chronoTimer.IntervalH) / 54;
            int IntervalOn_Height = (chronoTimer.Height - chronoTimer.IntervalV) / 7;
            chronoTimer.IntervalOn = Math.Min(IntervalOn_Height, IntervalOn_Width);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BtnSubmitClick != null)
            {
                //TODO
                BtnSubmitClick(this, EventArgs.Empty);
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

        private void PerfectChallengeGamePanel_Resize(object sender, EventArgs e)
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
            intTime = intTotalProblemCnt = intFinishedProblemCnt = 0;
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

        public bool IsAnswerCorrect()
        {
            return this.strCorrectAnswer.Trim() == this.txtAnswer.Text.Trim();
        }

        [Browsable(true)]
        public int Mode
        {
            get
            {
                return intMode;
            }
            set
            {
                intMode = value;
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
            }
        }
        
        public TimeSpan TimeUsed
        {
            get
            {
                return this.chronoTimer.TimeSpan;
            }
        }

    }
}
