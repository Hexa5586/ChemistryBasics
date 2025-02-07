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

    public partial class MainWindow : UIForm
    {
        private readonly string[] questionPaths = { "elements.json", "formulas.json" };
        private readonly Dictionary<string, string>[] dictQnA = { new Dictionary<string, string>(),
                                                         new Dictionary<string, string>()};
        private readonly string[] strAlerts =
        {
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的元素中文名称写出对应的元素符号；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的物质中文名称写出对应的化学式（有机物的要求会特别注明）；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par  3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式；\par  4. 请使用 \cf1 \b 英文输入法 \b0 \cf0 ，使用中文符号会导致判错。}",
        };


        private readonly Color colorSelected = Color.FromArgb(40, 0, 0, 0);

        private int intGameStatus = -1;
        private List<int> lstCurrentQuestionNums = new List<int>();
        private GamePanel? ActivePanel = null;
        private List<Control> ActiveTempPanels = new List<Control>();
        private int btnSubmitCounter = 0;
        private Dictionary<Control, float> initialFontSizes = new Dictionary<Control, float>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.tbctrlMain.ItemSize = new Size(1, 1);
            ReadQnAData();
            txtElementQnAs.Text = Dict2Csv(dictQnA[0]);
            txtFormulaQnAs.Text = Dict2Csv(dictQnA[1]);
            btnElementSave.Enabled = false;
            btnFormulaSave.Enabled = false;
            RecordInitialFontSizes(this);

            ElementPanel.Reset();
            FormulaPanel.Reset();
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

            foreach (Control childControl in this.tblpnlTab.Controls)
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

        private void ReadQnAData()
        {
            for (int i = 0; i < 2; i++)
            {
                if (!File.Exists(questionPaths[i]))
                {
                    FileStream fs = File.Create(questionPaths[i]);
                    fs.Dispose();
                }
                string strSerializedQuestions = File.ReadAllText(questionPaths[i]);
                Dictionary<string, string>? dict = 
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedQuestions);
                if(dict != null)
                {
                    dictQnA[i] = dict;
                }
                
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

        private void InitSettingsPanel_BtnStart_Click(object? sender, EventArgs e)
        {
            InitSettingsPanel? ActiveInitPanel = sender as InitSettingsPanel;
            if (ActiveInitPanel == null)
                return;

            int totalProblemCnt = ActiveInitPanel.TotalProblemCount;
            if(totalProblemCnt == 0)
            {
                MessageBox.Show("问题总数不可为零。请于设置页面确认题库非空。", "提示", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ActiveInitPanel.Dispose();
            ActiveTempPanels.Clear();

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
            ActivePanel.FocusOnTextBox();
        }
        private void GamePanel_BtnSubmitClick(object? sender, EventArgs e)
        {
            if(ActivePanel != null)
            {
                if ((++btnSubmitCounter) % 2 == 1)
                {
                    if (ActivePanel.IsAnswerCorrect())
                    {
                        ActivePanel.SetAnswerStatus(1);
                        ActivePanel.CorrectAnswerCount++;
                    }
                    else
                    {
                        ActivePanel.RecordAsError();
                        ActivePanel.SetAnswerStatus(-1);
                    }

                    ActivePanel.FinishedProblemCount++;
                }
                else
                {
                    ActivePanel.SetAnswerStatus(0);

                    if (ActivePanel.FinishedProblemCount >= ActivePanel.TotalProblemCount)
                    {
                        //tbctrlMain.Hide();
                        //MessageBox.Show("正确率：" + ActivePanel.GetCurrentAccuracy().ToString() + "%");
                        ResultPanel respnl = new ResultPanel(ActivePanel.Mode, ActivePanel.CorrectAnswerCount, ActivePanel.TotalProblemCount,
                                                             ActivePanel.errors);
                        tbctrlMain.TabPages[ActivePanel.Mode].Controls.Add(respnl);
                        respnl.Dock = DockStyle.Fill;
                        respnl.BtnCloseClick += ResultPanel_BtnClose_Click;
                        respnl.BringToFront();
                        respnl.Show();
                        ActiveTempPanels.Add(respnl);

                        if (ActivePanel != null)
                        {
                            ActivePanel.Reset();
                            btnSubmitCounter = 0;
                        }
                        ActivePanel = null;
                        return;
                    }

                    ActivePanel.QuestionString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Key;
                    ActivePanel.CorrectAnswerString = dictQnA[intGameStatus].ElementAt(lstCurrentQuestionNums[ActivePanel.FinishedProblemCount]).Value;
                }
            }
            else
            {
                MessageBox.Show("当前没有正在运行的GamePanel.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            UIButton? clickedBtn = sender as UIButton;
            if (clickedBtn != null)
            {
                tbctrlMain.SelectTab(clickedBtn.TabIndex);
                tbctrlMain.Show();
                int mode = tbctrlMain.SelectedIndex;

                foreach (Control con in tblpnlTab.Controls)
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
                    ReadQnAData();
                    foreach (Control pnl in ActiveTempPanels)
                    {
                        pnl.Dispose();
                    }
                    ActiveTempPanels.Clear();

                    InitSettingsPanel initpnl = new InitSettingsPanel(mode);
                    ActiveTempPanels.Add(initpnl);

                    tbctrlMain.TabPages[mode].Controls.Add(initpnl);
                    initpnl.Dock = DockStyle.Fill;
                    initpnl.AlertString = strAlerts[mode];
                    initpnl.MaximumCount = dictQnA[mode].Count;
                    initpnl.BringToFront();
                    initpnl.Show();

                    intGameStatus = mode;
                    initpnl.BtnStartClick += InitSettingsPanel_BtnStart_Click;
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

        private void ResultPanel_BtnClose_Click(object? sender, EventArgs e)
        {
            tbctrlMain.Hide();
        }

        private void main_Resize(object sender, EventArgs e)
        {
            ScaleFonts(this);
        }

    }


}
