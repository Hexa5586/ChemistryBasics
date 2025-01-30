using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sunny.UI;

namespace ChemistryBasics
{

    public partial class main : UIForm
    {
        private string[] questionPaths = { "data/elements.json", "data/formulas.json", "data/equations.json" };
        private Dictionary<string, string>[] dictQnA = { new Dictionary<string, string>(),
                                                         new Dictionary<string, string>(),
                                                         new Dictionary<string, string>()};
        private string[] strAlerts =
        {
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs25 \qc 1. 请根据给定的元素中文名称写出对应的元素符号；\par \qc 2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs25 \qc 1. 请根据给定的物质中文名称写出对应的化学式（有机物的要求会特别注明）；\par \qc 2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par \qc 3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs25 \qc 1. 请根据描述的化学反应写出对应的化学反应方程式（有机物的要求会特别注明）；\par \qc 2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par \qc 3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，系统会自行判断是否变为下标形式。}"
        };


        private Color colorSelected = Color.FromArgb(40, 0, 0, 0);

        private int intGameStatus = -1;
        private List<int> lstCurrentQuestionNums = new List<int>();
        private GamePanel? ActivePanel = null;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            ReadQnAData();
            
        }

        private void ReadQnAData()
        {
            try
            {
                for(int i = 0;i < 3; i++)
                {
                    string strSerializedQuestions = File.ReadAllText(questionPaths[i]);
                    dictQnA[i] =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedQuestions);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("读取JSON文件" + questionPaths[0] + "发生错误。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initSettingsPanel_BtnStart_Click(object sender, EventArgs e)
        {
            InitSettingsPanel? initpnl = sender as InitSettingsPanel;
            if (initpnl == null)
                return;

            int totalProblemCnt = initpnl.TotalProblemCount;
            initpnl.Dispose();

            if (intGameStatus == 0)
            {
                ActivePanel = ElementPanel;
            }
            else if (intGameStatus == 1)
            {
                ActivePanel = FormulaPanel;
            }
            else
            {
                ActivePanel = EquationPanel;
            }

            GameInit(totalProblemCnt);
        }

        private void GameInit(int totalProblemCnt)
        {
            
            ElementPanel.TotalProblemCount = totalProblemCnt;

            Random rand = new Random();
            HashSet<int> colCurrentQuestionNums = new HashSet<int>();
            while (colCurrentQuestionNums.Count != totalProblemCnt)
            {
                colCurrentQuestionNums.Add(rand.Next() % dictQnA[0].Count);
            }
            lstCurrentQuestionNums = new List<int>(colCurrentQuestionNums);

            ElementPanel.FinishedProblemCount = 0;
            ElementPanel.QuestionString = dictQnA[0].ElementAt(lstCurrentQuestionNums[ElementPanel.FinishedProblemCount]).Key;
            ElementPanel.CorrectAnswerString = dictQnA[0].ElementAt(lstCurrentQuestionNums[ElementPanel.FinishedProblemCount]).Value;

        }
        private async void elementModePanel_BtnSubmitClick(object sender, EventArgs e)
        {
            if (ElementPanel.AnswerString == ElementPanel.CorrectAnswerString)
            {
                ElementPanel.SetAnswerStatus(1);
                ElementPanel.CorrectAnswerCount++;
            }
            else
            {
                ElementPanel.SetAnswerStatus(-1);
            }

            ElementPanel.FinishedProblemCount++;
            await Task.Delay(600);
            ElementPanel.SetAnswerStatus(0);
            
            if(ElementPanel.FinishedProblemCount >= ElementPanel.TotalProblemCount)
            {
                tbctrlMain.Hide();
                double accuracy = ElementPanel.CorrectAnswerCount * 100.0 / ElementPanel.TotalProblemCount;
                MessageBox.Show("正确率：" + accuracy.ToString("F2") + "%");
                return;
            }

            ElementPanel.QuestionString = dictQnA[0].ElementAt(lstCurrentQuestionNums[ElementPanel.FinishedProblemCount]).Key;
            ElementPanel.CorrectAnswerString = dictQnA[0].ElementAt(lstCurrentQuestionNums[ElementPanel.FinishedProblemCount]).Value;
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            ElementPanel.Reset();

            UIButton? clickedBtn = sender as UIButton;
            if (clickedBtn != null)
            {
                tbctrlMain.Show();
                tbctrlMain.SelectTab(clickedBtn.TabIndex);
                int mode = tbctrlMain.SelectedIndex;

                foreach (Control con in tbpnlTab.Controls)
                {
                    if (con != null && con.GetType() == typeof(UIButton))
                    {
                        if (con.TabIndex == clickedBtn.TabIndex)
                        {
                            con.BackColor = colorSelected;
                        }
                        else
                        {
                            con.BackColor = Color.Transparent;
                        }

                    }
                }

                InitSettingsPanel initpnl = new InitSettingsPanel(mode);
                tbctrlMain.TabPages[mode].Controls.Add(initpnl);
                initpnl.Dock = DockStyle.Fill;
                initpnl.AlertString = strAlerts[mode];
                initpnl.MaximumCount = dictQnA[mode].Count;
                initpnl.BringToFront();
                initpnl.Show();

                intGameStatus = mode;
                initpnl.BtnStartClick += initSettingsPanel_BtnStart_Click;
                lstCurrentQuestionNums.Clear();
            }
        }

        
    }


}
