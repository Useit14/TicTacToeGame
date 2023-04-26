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
    public partial class ArchiveGames : Form
    {
        private List<int[,]> gameBoardForSeriliazation;

        public ArchiveGames(List<int[,]> gameBoardForSeriliazation)
        {
            InitializeComponent();
            this.gameBoardForSeriliazation = gameBoardForSeriliazation;
        }

        private void ArchiveGames_Load(object sender, EventArgs e)
        {
            List<Strategy> games = new List<Strategy>();
            foreach (var game in gameBoardForSeriliazation)
            {
                games.Add(new Strategy
                {
                    val1 = game[0, 0],
                    val2 = game[0, 1],
                    val3 = game[0, 2],
                    val4 = game[1, 0],
                    val5 = game[1, 1],
                    val6 = game[1, 2],
                    val7 = game[2, 0],
                    val8 = game[2, 1],
                    val9 = game[2, 2],
                });
            }
            dataGridView1.DataSource = games;
        }
    }
}
