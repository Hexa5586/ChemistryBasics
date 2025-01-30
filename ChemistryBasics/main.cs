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
        private string[] questionPaths = { "data/elements.json", "data/formulas.json" };
        private Dictionary<string, string>[] dictQnA = { new Dictionary<string, string>(),
                                                         new Dictionary<string, string>()};
        private string[] strAlerts =
        {
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs25 \par \b  说明： \b0 \par  1. 请根据给定的元素中文名称写出对应的元素符号；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs25 \par \b  说明： \b0 \par  1. 请根据给定的物质中文名称写出对应的化学式（有机物的要求会特别注明）；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par  3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式；\par  4.请使用 \cf1 \b 英文输入法 \b0 \cf0 ，使用中文符号会导致判错。}",
        };


        private Color colorSelected = Color.FromArgb(40, 0, 0, 0);

        private int intGameStatus = -1;
        private List<int> lstCurrentQuestionNums = new List<int>();
        private GamePanel? ActivePanel = null;
        private InitSettingsPanel? ActiveInitPanel = null;
        private int btnSubmitCounter = 0;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.tbctrlMain.ItemSize = new Size(0, 1);
            ReadQnAData();
            txtElementQnAs.Text = Dict2Csv(dictQnA[0]);
            txtFormulaQnAs.Text = Dict2Csv(dictQnA[1]);
            btnElementSave.Enabled = false;
            btnFormulaSave.Enabled = false;
        }

        private void ReadQnAData()
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    string strSerializedQuestions = File.ReadAllText(questionPaths[i]);
                    dictQnA[i] =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedQuestions);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("读取JSON文件发生错误。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Dict2Csv(Dictionary<string, string>? dict)
        {
            if (dict == null)
            {
                return "";
            }

            int dict_l = dict.Count();
            string csv = "";

            for (int i = 0; i < dict_l; i++)
            {
                csv += (dict.ElementAt(i).Key + ", " + dict.ElementAt(i).Value + "\r\n");
                //MessageBox.Show(csv);
            }
            return csv;
        }

        private string? Csv2SerializedDict(string? csv)
        {
            if (csv == null)
            {
                return "";
            }

            List<string> lines = new List<string>(csv.Split("\r\n"));
            int lines_cnt = lines.Count();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < lines_cnt; i++)
            {
                int half_comma_index = lines[i].IndexOf(',');
                int full_comma_index = lines[i].IndexOf('，');
                List<string> QnA;

                if (half_comma_index != -1)
                {
                    QnA = new List<string>(lines[i].Split(','));
                }
                else if (full_comma_index != -1)
                {
                    QnA = new List<string>(lines[i].Split('，'));
                }
                else
                {
                    MessageBox.Show("存在无逗号分割的行：第" + i.ToString() + "行。", "错误",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                dict.Add(QnA[0].Trim(), QnA[1].Trim());
            }

            return JsonConvert.SerializeObject(dict);
        }

        private void initSettingsPanel_BtnStart_Click(object sender, EventArgs e)
        {
            ActiveInitPanel = sender as InitSettingsPanel;
            if (ActiveInitPanel == null)
                return;

            int totalProblemCnt = ActiveInitPanel.TotalProblemCount;
            ActiveInitPanel.Dispose();

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
                return;
            }

            GameInit(totalProblemCnt);
        }

        private void GameInit(int totalProblemCnt)
        {
            if (ActivePanel == null)
            {
                return;
            }

            ActivePanel.TotalProblemCount = totalProblemCnt;

            Random rand = new Random();
            HashSet<int> colCurrentQuestionNums = new HashSet<int>();
            while (colCurrentQuestionNums.Count != totalProblemCnt)
            {
                colCurrentQuestionNums.Add(rand.Next() % dictQnA[intGameStatus].Count);
            }
            lstCurrentQuestionNums = new List<int>(colCurrentQuestionNums);

            ActivePanel.FinishedProblemCount = 0;
            ActivePanel.QuestionString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Key;
            ActivePanel.CorrectAnswerString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Value;

        }
        private void GamePanel_BtnSubmitClick(object sender, EventArgs e)
        {
            if ((++btnSubmitCounter) % 2 == 1) { 
                if (ActivePanel == null)
                {
                    MessageBox.Show("当前没有正在运行的GamePanel.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ActivePanel.IsAnswerCorrect())
                {
                    ActivePanel.SetAnswerStatus(1);
                    ActivePanel.CorrectAnswerCount++;
                }
                else
                {
                    ActivePanel.SetAnswerStatus(-1);
                }
            }
            else
            {
                ActivePanel.FinishedProblemCount++;
                ActivePanel.SetAnswerStatus(0);

                if (ActivePanel.FinishedProblemCount >= ActivePanel.TotalProblemCount)
                {
                    tbctrlMain.Hide();
                    double accuracy = ActivePanel.CorrectAnswerCount * 100.0 / ActivePanel.TotalProblemCount;
                    MessageBox.Show("正确率：" + accuracy.ToString("F2") + "%");
                    if (ActivePanel != null)
                    {
                        ActivePanel.Reset();
                    }
                    ActivePanel = null;
                    return;
                }

                ActivePanel.QuestionString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Key;
                ActivePanel.CorrectAnswerString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Value;
            }

            
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            if(ActiveInitPanel != null)
            {
                ActiveInitPanel.Dispose();
                ActiveInitPanel = null;
            }

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

                if (mode != 2)
                {
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

        private void txtElementQnAs_TextChanged(object sender, EventArgs e)
        {
            btnElementSave.Enabled = true;
        }

        private void txtFormulaQnAs_TextChanged(object sender, EventArgs e)
        {
            btnFormulaSave.Enabled = true;
        }

        private void btnElementSave_Click(object sender, EventArgs e)
        {
            string? serialized = Csv2SerializedDict(txtElementQnAs.Text.Trim());
            if (serialized != null)
            {
                File.WriteAllText(questionPaths[0], serialized);
                ReadQnAData();
                txtElementQnAs.Text = Dict2Csv(dictQnA[0]);
                btnElementSave.Enabled = false;
            }

        }

        private void btnFormulaSave_Click(object sender, EventArgs e)
        {
            string? serialized = Csv2SerializedDict(txtFormulaQnAs.Text.Trim());
            if (serialized != null)
            {
                File.WriteAllText(questionPaths[1], serialized);
                ReadQnAData();
                txtFormulaQnAs.Text = Dict2Csv(dictQnA[1]);
                btnFormulaSave.Enabled = false;
            }
        }
    }


}
