using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryBasics
{
    public partial class ResultPanel : UserControl
    {

        PrivateFontCollection pfc = new PrivateFontCollection();
        string[] strModeNames = { "元素符号默写大比拼", "化学式默写大比拼" };
        String[] ranks = { "S", "A⁺", "A", "B⁺", "B", "C" };
        int[] rank_borders = { 100, 90, 80, 70, 60, 0 };
        Color[] rank_colors =
        {
            Color.FromArgb(246, 199, 32),
            Color.FromArgb(246, 31, 31),
            Color.FromArgb(246, 31, 199),
            Color.FromArgb(31, 42, 246),
            Color.FromArgb(36, 218, 64),
            Color.FromArgb(127, 127, 127)
        };
        public event EventHandler BtnCloseClick;
        private Dictionary<Control, float> initialFontSizes = new Dictionary<Control, float>();

        public ResultPanel(int mode, int correct_answer_cnt, int total_cnt, 
            List<Tuple<string, string, string>>? errors = null)
        {
            InitializeComponent();

            try
            {
                pfc.AddFontFile("unispace bd.ttf");
            }
            finally
            {
                ;
            }
            

            lblMode.Text = strModeNames[mode];
            lblCorrectnTotal.Text = correct_answer_cnt.ToString() + "/" + total_cnt.ToString();
            double acc = correct_answer_cnt * 100.0 / total_cnt;
            SetScore(acc);
            if(errors != null)
            {
                foreach(Tuple<string, string, string> err in errors)
                {
                    dataErrors.Rows.Add(err.Item1, err.Item2, err.Item3);
                }
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

            List<Control> controls = new List<Control> { lblAccuracy, lblRank };
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

        public void SetScore(double accuracy)
        {
            lblAccuracy.Text = accuracy.ToString("F1") + "%";
            for (int i = 0; i < 6; i++)
            {
                if (accuracy >= rank_borders[i])
                {
                    lblRank.Text = ranks[i];
                    lblRank.ForeColor = rank_colors[i];
                    break;
                }
            }
        }

        private void ResultPanel_Load(object sender, EventArgs e)
        {
            lblAccuracy.Font = new Font(pfc.Families[0], lblAccuracy.Font.Size, lblAccuracy.Font.Style);
            lblRank.Font = new Font(pfc.Families[0], lblRank.Font.Size, lblRank.Font.Style);
            dataErrors.ClearSelection();
            RecordInitialFontSizes(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (BtnCloseClick != null)
            {
                BtnCloseClick(sender, e);
            }

            this.Hide();
            this.Dispose();
        }

        private void ResultPanel_Resize(object sender, EventArgs e)
        {
            ScaleFonts(this);
        }
    }
}
