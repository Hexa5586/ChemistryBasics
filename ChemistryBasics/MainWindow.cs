using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Sunny.UI;

namespace ChemistryBasics
{

    public partial class MainWindow : UIForm
    {
        private readonly static string[] questionPaths = { "elements.json", "formulas.json" };
        private readonly static string[] rankingsPaths = { "elements_rks.json", "formulas_rks.json" };
        private readonly static string settingsPath = "settings.json";

        private Dictionary<string, string>[] dictQnA = { new Dictionary<string, string>(),
                                                         new Dictionary<string, string>()};
        private readonly string[] strAlerts =
        {
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的元素中文名称写出对应的元素符号；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的物质中文名称写出对应的化学式（有机物的要求会特别注明）；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par  3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式；\par  4. 请使用 \cf1 \b 英文输入法 \b0 \cf0 ，使用中文符号会导致判错。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的元素中文名称写出对应的元素符号；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par  3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式；\par  4. 请使用 \cf1 \b 英文输入法 \b0 \cf0 ，使用中文符号会导致判错；\par  5. 完美挑战模式共20题，要求 \cf1 \b 全部做答正确 \b0 \cf0 方可按完成时间计入排名，若出现作答错误则直接中断答题。}",
            @"{\rtf1\ansi\ansicpg936{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;} \fs50 \par \b  说明： \fs35 \b0 \par  1. 请根据给定的物质中文名称写出对应的化学式（有机物的要求会特别注明）；\par  2. 请注意 \cf1 \b 区分大小写 \b0 \cf0 。混淆大小写将会被判为错误答案；\par  3. 数字 \cf2 \b 直接输入 \b0 \cf0 即可，会自动转换为下标形式；\par  4. 请使用 \cf1 \b 英文输入法 \b0 \cf0 ，使用中文符号会导致判错；\par  5. 完美挑战模式共20题，要求 \cf1 \b 全部做答正确 \b0 \cf0 方可按完成时间计入排名，若出现作答错误则直接中断答题。}",

        };

        private readonly Color colorSelected = Color.FromArgb(40, 0, 0, 0);

        private int intGameStatus = -1;
        private List<int> lstCurrentQuestionNums = new List<int>();
        private GamePanel? ActiveGamePanel = null;
        private PerfectGamePanel? ActivePerfectGamePanel = null;
        private List<Control> ActivePanels = new List<Control>();
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

            /*
            Form test = new Test();
            test.Show();
            */


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
                if (dict != null)
                {
                    dictQnA[i] = dict;
                }

            }
        }

        private void WriteQnAData()
        {
            string? serialized_element = Csv2SerializedDict(txtElementQnAs.Text.Trim());
            if (serialized_element != null)
            {
                File.WriteAllText(questionPaths[0], serialized_element);
            }

            string? serialized_formula = Csv2SerializedDict(txtFormulaQnAs.Text.Trim());
            if (serialized_formula != null)
            {
                File.WriteAllText(questionPaths[1], serialized_formula);
            }
        }

        public static string? ReadSettingItem(string key)
        {
            if (!File.Exists(settingsPath))
            {
                FileStream fs = File.Create(settingsPath);
                fs.Dispose();
                return null;
            }
            string strSerializedSettings = File.ReadAllText(settingsPath);
            Dictionary<string, string>? settings =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedSettings);

            if(settings == null)
            {
                return null;
            }
            else if (!settings.ContainsKey(key))
            {
                return null;
            }
            else
            {
                return settings[key];
            }

        }

        public static void WriteSettingItem(string key, string value)
        {
            if (!File.Exists(settingsPath))
            {
                FileStream fs = File.Create(settingsPath);
                fs.Dispose();
            }
            string strSerializedSettings = File.ReadAllText(settingsPath);
            Dictionary<string, string>? settings =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedSettings);

            if (settings == null)
            {
                settings = new Dictionary<string, string>();
            }
            
            settings[key] = value;
            string? strNewSerializedSettings = JsonConvert.SerializeObject(settings);
            if (strNewSerializedSettings != null)
            {
                File.WriteAllText(settingsPath, strNewSerializedSettings);
            }
        }

        private void AddRankingsData(int mode, string name, string time)
        {
            if (!File.Exists(rankingsPaths[mode]))
            {
                FileStream fs = File.Create(rankingsPaths[mode]);
                fs.Dispose();
            }
            string strSerializedRankings = File.ReadAllText(rankingsPaths[mode]);
            Dictionary<string, string>? rankings =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedRankings);

            if (rankings == null)
            {
                rankings = new Dictionary<string, string>();
            }

            if(!rankings.ContainsKey(name) || String.Compare(rankings[name], time) == 1)
            {
                rankings[name] = time;
                rankings = rankings.OrderBy(x => x.Value).ToDictionary();
                string? strNewSerializedRankings = JsonConvert.SerializeObject(rankings);

                if (strNewSerializedRankings != null)
                {
                    File.WriteAllText(rankingsPaths[mode], strNewSerializedRankings);
                }
            }
        }

        public void ClearActivePanels()
        {
            foreach (Control pnl in ActivePanels)
            {
                pnl.Hide();
                pnl.Dispose();
            }
            ActivePanels.Clear();

            return;
        }

        private static string Dict2Csv(Dictionary<string, string>? dict)
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

        private static string? Csv2SerializedDict(string? csv)
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

        public static bool Authenticate()
        {
            string? correct_psd = ReadSettingItem("psd");
            if (correct_psd == null)
            {
                correct_psd = "";
            }

            if(correct_psd == "")
            {
                return true;
            }

            PasswordDialog psddlg = new PasswordDialog(correct_psd);
            psddlg.ShowDialog();
            if(psddlg.DialogResult == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            ActiveGamePanel = null;
            ActivePerfectGamePanel = null;
            UIButton? clickedBtn = sender as UIButton;
            if (clickedBtn != null)
            {
                tbctrlMain.SelectTab(clickedBtn.TabIndex);
                tbctrlMain.Show();
                int selected_item = tbctrlMain.SelectedIndex;

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
                
                ReadQnAData();
                ClearActivePanels();

                if (selected_item == 0 || selected_item == 1)
                {
                    intGameStatus = selected_item;
                    GamePanel gmpnl = new GamePanel(selected_item);
                    ActivePanels.Add(gmpnl);
                    ActiveGamePanel = gmpnl;

                    tbctrlMain.TabPages[selected_item].Controls.Add(gmpnl);
                    gmpnl.Dock = DockStyle.Fill;
                    gmpnl.BtnSubmitClick += GamePanel_BtnSubmitClick;
                    gmpnl.Show();

                    InitSettingsPanel initpnl = new InitSettingsPanel(selected_item);
                    ActivePanels.Add(initpnl);

                    tbctrlMain.TabPages[selected_item].Controls.Add(initpnl);
                    initpnl.Dock = DockStyle.Fill;
                    initpnl.AlertString = strAlerts[selected_item];
                    initpnl.MaximumCount = dictQnA[selected_item].Count;
                    initpnl.BringToFront();
                    initpnl.Show();

                    initpnl.BtnStartClick += InitSettingsPanel_BtnStart_Click;
                    lstCurrentQuestionNums.Clear();

                }

                else if (selected_item == 2)
                {
                    PerfectGamePanel pgmpnl = new PerfectGamePanel(selected_item);
                    ActivePanels.Add(pgmpnl);
                    ActivePerfectGamePanel = pgmpnl;

                    tbctrlMain.TabPages[selected_item].Controls.Add(pgmpnl);
                    pgmpnl.Dock = DockStyle.Fill;
                    pgmpnl.BtnSubmitClick += PerfectGamePanel_BtnSubmitClick;
                    pgmpnl.Show();

                    PerfectRankingPanel prkspnl = new PerfectRankingPanel();
                    ActivePanels.Add(prkspnl);

                    tbctrlMain.TabPages[selected_item].Controls.Add(prkspnl);
                    prkspnl.Dock = DockStyle.Fill;
                    prkspnl.BtnStartClick += PerfectRankingPanel_BtnStart_Click;
                    prkspnl.BringToFront();
                    prkspnl.Show();

                }
                else
                {
                    ReadQnAData();
                    txtElementQnAs.Text = Dict2Csv(dictQnA[0]);
                    btnElementSave.Enabled = false;
                    txtFormulaQnAs.Text = Dict2Csv(dictQnA[1]);
                    btnFormulaSave.Enabled = false;
                }

            }
        }

        private void PerfectRankingPanel_BtnStart_Click(object? sender, EventArgs e)
        {
            PerfectRankingPanel? prkspnl = sender as PerfectRankingPanel;

            if (prkspnl != null && ActivePerfectGamePanel != null)
            {
                if (dictQnA[prkspnl.SelectedMode].Count < InitSettingsPanel.intPerfectChallengeProblemCount)
                {
                    MessageBox.Show("问题总数不足" + InitSettingsPanel.intPerfectChallengeProblemCount.ToString() +
                            "。请于设置页面补充题库。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                prkspnl.Dispose();
                ActivePerfectGamePanel.Mode = prkspnl.SelectedMode;
                intGameStatus = 2 + prkspnl.SelectedMode;
                InitSettingsPanel initpnl = new InitSettingsPanel(intGameStatus);
                ActivePanels.Add(initpnl);

                tbctrlMain.TabPages[2].Controls.Add(initpnl);
                initpnl.Dock = DockStyle.Fill;
                initpnl.AlertString = strAlerts[intGameStatus];
                initpnl.BringToFront();
                initpnl.Show();

                initpnl.BtnStartClick += InitSettingsPanel_BtnStart_Click;
                lstCurrentQuestionNums.Clear();
            }
        }

        private void InitSettingsPanel_BtnStart_Click(object? sender, EventArgs e)
        {
            InitSettingsPanel? ActiveInitPanel = sender as InitSettingsPanel;
            if (ActiveInitPanel == null)
                return;

            int totalProblemCnt = ActiveInitPanel.TotalProblemCount;
            if (totalProblemCnt == 0)
            {
                MessageBox.Show("问题总数不可为零。请于设置页面确认题库非空。", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ActiveInitPanel.Dispose();

            GameInit(totalProblemCnt);

        }

        private void GameInit(int totalProblemCnt)
        {
            if (ActiveGamePanel == null && ActivePerfectGamePanel == null)
            {
                return;
            }

            Random rand = new Random();
            HashSet<int> colCurrentQuestionNums = new HashSet<int>();

            if (ActiveGamePanel != null)
            {
                int QnAIndex = intGameStatus;
                while (colCurrentQuestionNums.Count != totalProblemCnt)
                {
                    colCurrentQuestionNums.Add(rand.Next() % dictQnA[QnAIndex].Count);
                }
                lstCurrentQuestionNums = new List<int>(colCurrentQuestionNums);
                ActiveGamePanel.TotalProblemCount = totalProblemCnt;
                ActiveGamePanel.FinishedProblemCount = 0;
                ActiveGamePanel.QuestionString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[0]).Key;
                ActiveGamePanel.CorrectAnswerString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[0]).Value;
                ActiveGamePanel.FocusOnTextBox();

            }

            else if (ActivePerfectGamePanel != null)
            {
                int QnAIndex = intGameStatus - 2;
                while (colCurrentQuestionNums.Count != totalProblemCnt)
                {
                    colCurrentQuestionNums.Add(rand.Next() % dictQnA[QnAIndex].Count);
                }
                lstCurrentQuestionNums = new List<int>(colCurrentQuestionNums);
                ActivePerfectGamePanel.TotalProblemCount = totalProblemCnt;
                ActivePerfectGamePanel.FinishedProblemCount = 0;
                ActivePerfectGamePanel.QuestionString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[0]).Key;
                ActivePerfectGamePanel.CorrectAnswerString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[0]).Value;
                ActivePerfectGamePanel.FocusOnTextBox();
                ActivePerfectGamePanel.TimerStart();
            }

        }

        private void GamePanel_BtnSubmitClick(object? sender, EventArgs e)
        {
            int QnAIndex = intGameStatus;
            if (ActiveGamePanel != null)
            {
                if ((++btnSubmitCounter) % 2 == 1)
                {
                    if (ActiveGamePanel.IsAnswerCorrect())
                    {
                        ActiveGamePanel.SetAnswerStatus(1);
                        ActiveGamePanel.CorrectAnswerCount++;
                    }
                    else
                    {
                        ActiveGamePanel.RecordAsError();
                        ActiveGamePanel.SetAnswerStatus(-1);
                    }

                    ActiveGamePanel.FinishedProblemCount++;
                }
                else
                {
                    ActiveGamePanel.SetAnswerStatus(0);
                    ActiveGamePanel.AnswerString = "";

                    if (ActiveGamePanel.FinishedProblemCount >= ActiveGamePanel.TotalProblemCount)
                    {
                        ResultPanel respnl = new ResultPanel(ActiveGamePanel.Mode, ActiveGamePanel.CorrectAnswerCount, ActiveGamePanel.TotalProblemCount,
                                                             ActiveGamePanel.errors);
                        ClearActivePanels();
                        tbctrlMain.TabPages[ActiveGamePanel.Mode].Controls.Add(respnl);
                        respnl.Dock = DockStyle.Fill;
                        respnl.BringToFront();
                        respnl.Show();
                        ActivePanels.Add(respnl);

                        ActiveGamePanel.Reset();
                        btnSubmitCounter = 0;
                        ActiveGamePanel = null;
                        return;
                    }

                    ActiveGamePanel.QuestionString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[ActiveGamePanel.FinishedProblemCount]).Key;
                    ActiveGamePanel.CorrectAnswerString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[ActiveGamePanel.FinishedProblemCount]).Value;
                }
            }
            else
            {
                MessageBox.Show("当前没有正在运行的GamePanel.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void PerfectGamePanel_BtnSubmitClick(object? sender, EventArgs e)
        {
            int QnAIndex = intGameStatus - 2;
            if (ActivePerfectGamePanel != null)
            {
                if (ActivePerfectGamePanel.IsAnswerCorrect())
                {
                    ActivePerfectGamePanel.AnswerString = "";
                    ActivePerfectGamePanel.FinishedProblemCount++;
                    if (ActivePerfectGamePanel.FinishedProblemCount >= ActivePerfectGamePanel.TotalProblemCount)
                    {
                        ActivePerfectGamePanel.TimerStop();
                        TimeSpan tpTimeUsed = ActivePerfectGamePanel.TimeUsed;
                        ResultPanel respnl = new ResultPanel(intGameStatus, false, tpTimeUsed);
                        ClearActivePanels();
                        tbctrlMain.TabPages[2].Controls.Add(respnl);
                        respnl.Dock = DockStyle.Fill;
                        respnl.BringToFront();
                        respnl.Show();
                        ActivePanels.Add(respnl);

                        RecordDialog rdlg = new RecordDialog();
                        rdlg.ShowDialog();
                        if (rdlg.DialogResult == DialogResult.OK)
                        {
                            string strTimeUsed = tpTimeUsed.Minutes.ToString("D2") + ":" + tpTimeUsed.Seconds.ToString("D2")
                                + "." + tpTimeUsed.Milliseconds.ToString("D3");
                            AddRankingsData(QnAIndex, rdlg.GetName(), strTimeUsed);
                        }

                        ActivePerfectGamePanel.Reset();
                        btnSubmitCounter = 0;
                        ActiveGamePanel = null;
                        return;
                    }

                    //MessageBox.Show(ActivePerfectGamePanel.FinishedProblemCount.ToString());
                    ActivePerfectGamePanel.QuestionString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[ActivePerfectGamePanel.FinishedProblemCount]).Key;
                    ActivePerfectGamePanel.CorrectAnswerString = dictQnA[QnAIndex].ElementAt(lstCurrentQuestionNums[ActivePerfectGamePanel.FinishedProblemCount]).Value;
                }
                else
                {
                    ActivePerfectGamePanel.TimerStop();
                    ActivePerfectGamePanel.RecordAsError();
                    ResultPanel respnl = new ResultPanel(intGameStatus, true, ActivePerfectGamePanel.TimeUsed, ActivePerfectGamePanel.errors);
                    ClearActivePanels();
                    tbctrlMain.TabPages[2].Controls.Add(respnl);
                    respnl.Dock = DockStyle.Fill;
                    respnl.BringToFront();
                    respnl.Show();
                    ActivePanels.Add(respnl);

                    ActivePerfectGamePanel.Reset();
                    btnSubmitCounter = 0;
                    ActiveGamePanel = null;
                    return;
                }
            }
            else
            {
                MessageBox.Show("当前没有正在运行的PerfectChallengeGamePanel.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            if (Authenticate())
            {
                WriteQnAData();
            }
            ReadQnAData();
            txtElementQnAs.Text = Dict2Csv(dictQnA[0]);
            btnElementSave.Enabled = false;
        }

        private void btnFormulaSave_Click(object sender, EventArgs e)
        {
            if (Authenticate())
            {
                WriteQnAData();
            }
            ReadQnAData();
            txtFormulaQnAs.Text = Dict2Csv(dictQnA[1]);
            btnFormulaSave.Enabled = false;
        }

        private void main_Resize(object sender, EventArgs e)
        {
            ScaleFonts(this);
        }

        private void btnPasswordConfirm_Click(object sender, EventArgs e)
        {
            string? correct_psd = ReadSettingItem("psd");
            if (correct_psd == null)
            {
                correct_psd = "";
            }

            if(txtOldPassword.Text == correct_psd)
            {
                WriteSettingItem("psd", txtNewPassword.Text);
                MessageBox.Show("管理员密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("旧密码错误，管理员密码修改失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }
    }


}
