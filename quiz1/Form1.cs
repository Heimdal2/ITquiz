using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string[]> DATA;
        int SPMn;
        int poeng;


        public List<string[]> readCsv(string path) {
            string[] lines = System.IO.File.ReadAllLines(path);
            List<string[]> columns = new List<string[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                columns.Add(lines[i].Split(','));
            }

            return columns;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DATA = readCsv("https://raw.githubusercontent.com/Heimdal2/ITquiz/main/sporsmal.csv"); // readCsv("C:/Users/AndreasMyklebustKris/OneDrive - Rogaland Fylkeskommune EES/skole oppgaver/IT/quiz1/quiz1/sporsmal.csv");
            //SoS = new Dictionary<string, string>();
            //for (int row = 0; row < DATA.Count; row++) {
            //    SoS.Add(DATA[row][0], DATA[row][1]);
            //}

            SPMn = 0;
            poeng = 0;

            SPM.Text = DATA[SPMn][0];
            POENG.Text = "poeng: " + poeng;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (SPMn >= DATA.Count)
            {
                Thread.Sleep(5000);
                Application.Exit();
            }
            else
            {
                if (INP.Text == DATA[SPMn][1])
                {
                    poeng++;
                }
                POENG.Text = "poeng: " + poeng;
                SPMn++;
                prog.Value += (int)Math.Round((double) 100 / (DATA.Count - 1));
                SPM.Text = DATA[SPMn][0];
                INP.Text = "";
            }
        }
    }
}
