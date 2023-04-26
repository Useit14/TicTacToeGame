using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class AllStrategies : Form
    {

        Dictionary<Form1.ResultsGames, List<int[,]>> devidesGames;

        public AllStrategies(Dictionary<Form1.ResultsGames, List<int[,]>> _devidesGames)
        {
            InitializeComponent();
            this.devidesGames = _devidesGames;
        }

        private void AllStrategies_Load(object sender, EventArgs e)
        {
            List<Strategy> winStrategies = new List<Strategy>();
            List<Strategy> notWinStrategies = new List<Strategy>();
            List<Strategy> drawStrategies = new List<Strategy>();

            foreach (var list in devidesGames[Form1.ResultsGames.Win])
            {
                winStrategies.Add(new Strategy()
                {
                    val1 = list[0, 0],
                    val2 = list[0, 1],
                    val3 = list[0, 2],
                    val4 = list[1, 0],
                    val5 = list[1, 1],
                    val6 = list[1, 2],
                    val7 = list[2, 0],
                    val8 = list[2, 1],
                    val9 = list[2, 2],
                });
            }

            foreach (var list in devidesGames[Form1.ResultsGames.NotWin])
            {
                notWinStrategies.Add(new Strategy()
                {
                    val1 = list[0, 0],
                    val2 = list[0, 1],
                    val3 = list[0, 2],
                    val4 = list[1, 0],
                    val5 = list[1, 1],
                    val6 = list[1, 2],
                    val7 = list[2, 0],
                    val8 = list[2, 1],
                    val9 = list[2, 2],
                });
            }

            foreach (var list in devidesGames[Form1.ResultsGames.Draw])
            {
                drawStrategies.Add(new Strategy()
                {
                    val1 = list[0, 0],
                    val2 = list[0, 1],
                    val3 = list[0, 2],
                    val4 = list[1, 0],
                    val5 = list[1, 1],
                    val6 = list[1, 2],
                    val7 = list[2, 0],
                    val8 = list[2, 1],
                    val9 = list[2, 2],
                });
            }

            dataGridView1.DataSource = winStrategies;
            dataGridView2.DataSource = notWinStrategies;
            dataGridView3.DataSource = drawStrategies;
        }
    }
}
