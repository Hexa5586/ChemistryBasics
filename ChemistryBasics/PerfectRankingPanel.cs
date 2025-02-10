using Newtonsoft.Json;
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

    public partial class PerfectRankingPanel : UserControl
    {
        private readonly string[] rankingsPaths = { "elements_rks.json", "formulas_rks.json" };
        public event EventHandler? BtnStartClick;

        public PerfectRankingPanel()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (BtnStartClick != null)
            {
                BtnStartClick(this, EventArgs.Empty);
            }
        }

        private void PerfectRankingPanel_Load(object sender, EventArgs e)
        {
            cmbMode.SelectedIndex = 0;
        }

        private void LoadRankingsData(int mode)
        {
            dataRanks.ClearRows();
            if (!File.Exists(rankingsPaths[mode]))
            {
                FileStream fs = File.Create(rankingsPaths[mode]);
                fs.Dispose();
            }
            string strSerializedRankings = File.ReadAllText(rankingsPaths[mode]);
            Dictionary<string, string>? dictRankings =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(strSerializedRankings);

            if (dictRankings != null)
            {
                int index = 1;
                foreach (KeyValuePair<string, string> par in dictRankings)
                {
                    dataRanks.Rows.Add(index, par.Key, par.Value);
                    index++;
                }
            }
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRankingsData(cmbMode.SelectedIndex);
            dataRanks.ClearSelection();
        }

        private void btnRankingsClear_Click(object sender, EventArgs e)
        {
            if (MainWindow.Authenticate())
            {
                if (!File.Exists(rankingsPaths[cmbMode.SelectedIndex]))
                {
                    FileStream fs = File.Create(rankingsPaths[cmbMode.SelectedIndex]);
                    fs.Dispose();
                }
                File.WriteAllText(rankingsPaths[cmbMode.SelectedIndex], "{}");
                LoadRankingsData(cmbMode.SelectedIndex);
            }
            
        }

        public int SelectedMode
        {
            get
            {
                return cmbMode.SelectedIndex;
            }
        }

    }
}
