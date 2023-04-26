using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    [Serializable]
    public class GameBoardList
    {
        public List<int[,]> GameBoards { get; set; }
    }
}
