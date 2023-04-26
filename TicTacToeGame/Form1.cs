using Newtonsoft.Json;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum ResultsGames
        {
            Win,
            NotWin,
            Draw
        }
        Dictionary<ResultsGames, List<int[,]>> devidesGames = new Dictionary<ResultsGames, List<int[,]>>();
        List<int[,]> gameBoardForSeriliazation = new List<int[,]>();
        int countStep = 0;
        int player = 0;
        private Random random = new Random();
        private void buttonFindStrategies_Click(object sender, EventArgs e)
        {
            int[,] gameBoard = new int[3, 3] { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
            int currentPlayer = 0; // Начинает игрок с нулевым значением
            List<int[,]> archiveStrategies = GetAllGameStrategies(gameBoard, currentPlayer);
            devidesGames = CategorizeGameStrategies(archiveStrategies);
            buttonStartOrNext.Enabled = true;
            buttonShowStrategies.Enabled = true;
        }



        private void buttonStartOrNext_Click(object sender, EventArgs e)
        {

            if (countStep == 0)
            {
                player = 0;
                buttonStartOrNext.Text = "Следующий ход";
            }
            else
            {
                player = player == 1 ? 0 : 1;
            }
            int[,] currentGameBoard = ConvertToTwoDimensionalArray(groupBoxCells);
            int[] findedIndex = GetNextIndex(currentGameBoard, devidesGames, player);
            if (findedIndex[0] == -1)
            {
                do
                {
                    findedIndex[0] = random.Next(0, 3);
                    findedIndex[1] = random.Next(0, 3);
                } while (!IsFreeIndex(new int[2] { findedIndex[0], findedIndex[1] }, currentGameBoard));
            }
            if (radioXPlayer.Checked && player == 0 || radioOPlayer.Checked && player == 1)
            {
                currentGameBoard[findedIndex[0], findedIndex[1]] = player;
            }
            else
            {
                int randomIndexRow = -1;
                int randomIndexCol = -1;
                do
                {
                    randomIndexRow = random.Next(0, 3);
                    randomIndexCol = random.Next(0, 3);
                } while (!IsFreeIndex(new int[2] { randomIndexRow, randomIndexCol }, currentGameBoard));
                currentGameBoard[randomIndexRow, randomIndexCol] = player;
            }
            ConvertToGroupBoxCells(currentGameBoard);
            countStep++;
            if (IsGameOver(currentGameBoard))
            {
                MessageBox.Show("Игра окончена");
                gameBoardForSeriliazation.Add(currentGameBoard);
                Serialization(gameBoardForSeriliazation);
                for (int i = 0; i < groupBoxCells.Controls.Count; i++)
                {
                    groupBoxCells.Controls[i].Text = "";
                }
                buttonStartOrNext.Text = "Начать";
                countStep = 0;
                return;

            }
        }

        private int[] GetNextIndex(int[,] gameBoard, Dictionary<ResultsGames, List<int[,]>> strategies, int currentPlayer)
        {
            int[] index = new int[2] { -1, -1 };

            // ищем выигрышную стратегию с сечением, равным текущему положению поля
            if (strategies[ResultsGames.Win].Count > 0)
            {
                foreach (int[,] winStrategy in strategies[ResultsGames.Win])
                {
                    // проверяем, что сечение стратегии совпадает с текущим положением поля
                    bool match = true;
                    for (int i = 0; i < gameBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < gameBoard.GetLength(1); j++)
                        {
                            if (winStrategy[i, j] != gameBoard[i, j])
                            {
                                match = false;
                                break;
                            }
                        }
                    }
                    if (match)
                    {
                        // ищем первую свободную ячейку в выигрышной стратегии
                        for (int i = 0; i < winStrategy.GetLength(0); i++)
                        {
                            for (int j = 0; j < winStrategy.GetLength(1); j++)
                            {
                                if (winStrategy[i, j] == player && gameBoard[i, j] == -1)
                                {
                                    index[0] = i;
                                    index[1] = j;
                                    return index;
                                }
                            }
                        }
                    }
                }
            }

            // проверяем, есть ли невыигрышная стратегия для текущего игрока
            if (strategies[ResultsGames.NotWin].Count > 0)
            {
                // выбираем первую невыигрышную стратегию из списка
                int[,] notWinStrategy = strategies[ResultsGames.NotWin][0];

                // ищем первую свободную ячейку в невыигрышной стратегии
                for (int i = 0; i < notWinStrategy.GetLength(0); i++)
                {
                    for (int j = 0; j < notWinStrategy.GetLength(1); j++)
                    {
                        if (notWinStrategy[i, j] == -1 && gameBoard[i, j] == currentPlayer)
                        {
                            index[0] = i;
                            index[1] = j;
                            return index;
                        }
                    }
                }
            }

            // если нет стратегий, выбираем случайную свободную ячейку
            List<int[]> emptyCells = new List<int[]>();
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == -1)
                    {
                        emptyCells.Add(new int[2] { i, j });
                    }
                }
            }
            if (emptyCells.Count > 0)
            {
                index = emptyCells[random.Next(emptyCells.Count)];
            }

            return index;
        }



        public int[,] ConvertToTwoDimensionalArray(GroupBox groupBox)
        {

            int[,] array = new int[3, 3];
            int indexGroupBox = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (groupBox.Controls[indexGroupBox].Text == "")
                    {
                        array[i, j] = -1;
                    }
                    else if (groupBox.Controls[indexGroupBox].Text == "X")
                    {
                        array[i, j] = 0;
                    }
                    else if (groupBox.Controls[indexGroupBox].Text == "O")
                    {
                        array[i, j] = 1;
                    }
                    indexGroupBox++;
                }
            }
            return array;
        }

        private void ConvertToGroupBoxCells(int[,] gameBoard)
        {
            int indexGroupBox = 0;
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == 0)
                    {
                        groupBoxCells.Controls[indexGroupBox].Text = "X";
                    }
                    else if (gameBoard[i, j] == 1)
                    {
                        groupBoxCells.Controls[indexGroupBox].Text = "O";
                    }
                    else if (gameBoard[i, j] == -1)
                    {
                        groupBoxCells.Controls[indexGroupBox].Text = "";
                    }
                    indexGroupBox++;
                }
            }
        }

        private Dictionary<ResultsGames, List<int[,]>> CategorizeGameStrategies(List<int[,]> strategies)
        {
            Dictionary<ResultsGames, List<int[,]>> categorizedStrategies = new Dictionary<ResultsGames, List<int[,]>>()
            {
                { ResultsGames.Win, new List<int[,]>() },
                { ResultsGames.NotWin, new List<int[,]>() },
                { ResultsGames.Draw, new List<int[,]>() }
            };

            foreach (int[,] strategy in strategies)
            {
                if (IsWinningStrategy(strategy))
                {
                    categorizedStrategies[ResultsGames.Win].Add(strategy);
                }
                else if (IsDrawStrategy(strategy))
                {
                    categorizedStrategies[ResultsGames.Draw].Add(strategy);
                }
                else
                {
                    categorizedStrategies[ResultsGames.NotWin].Add(strategy);
                }
            }

            return categorizedStrategies;
        }

        private bool IsWinningStrategy(int[,] strategy)
        {
            int[,] winConditions = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                int a = winConditions[i, 0];
                int b = winConditions[i, 1];
                int c = winConditions[i, 2];

                if (strategy[a / 3, a % 3] != -1 && strategy[a / 3, a % 3] == strategy[b / 3, b % 3] && strategy[a / 3, a % 3] == strategy[c / 3, c % 3])
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsDrawStrategy(int[,] strategy)
        {
            for (int i = 0; i < strategy.GetLength(0); i++)
            {
                for (int j = 0; j < strategy.GetLength(1); j++)
                {
                    if (strategy[i, j] == -1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        public List<int[,]> GetAllGameStrategies(int[,] gameBoard, int currentPlayer)
        {
            List<int[,]> strategies = new List<int[,]>();

            // Проверяем, не закончилась ли игра
            if (IsGameOver(gameBoard))
            {
                strategies.Add(gameBoard);
                return strategies;
            }

            // Проходим по всем ячейкам доски и генерируем новые стратегии
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == -1) // Если ячейка пустая
                    {
                        int[,] newBoard = (int[,])gameBoard.Clone(); // Создаем копию доски
                        newBoard[i, j] = currentPlayer; // Делаем ход

                        // Генерируем новые стратегии для следующего игрока
                        List<int[,]> nextStrategies = GetAllGameStrategies(newBoard, 1 - currentPlayer);

                        // Добавляем текущий ход к каждой из новых стратегий
                        foreach (int[,] strategy in nextStrategies)
                        {
                            strategies.Add(strategy);
                        }
                    }
                }
            }

            return strategies;
        }

        private bool IsGameOver(int[,] gameBoard)
        {
            // Проверяем все возможные выигрышные комбинации
            int[,] winConditions = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                int a = winConditions[i, 0];
                int b = winConditions[i, 1];
                int c = winConditions[i, 2];

                if (gameBoard[a / 3, a % 3] != -1 && gameBoard[a / 3, a % 3] == gameBoard[b / 3, b % 3] && gameBoard[a / 3, a % 3] == gameBoard[c / 3, c % 3])
                {
                    return true; // Если есть выигрышная комбинация, то игра окончена
                }
            }

            // Проверяем, есть ли еще свободные ячейки
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == -1)
                    {
                        return false; // Если есть свободная ячейка, то игра не окончена
                    }
                }
            }

            return true; // Если все ячейки заняты и нет выигрышной комбинации, то игра окончена
        }



        private bool IsFreeIndex(int[] index, int[,] _strategy)
        {
            return _strategy[index[0], index[1]] == -1;
        }

        private void buttonShowStrategies_Click(object sender, EventArgs e)
        {
            AllStrategies allStrategies = new AllStrategies(devidesGames);
            allStrategies.Show();
        }

        private void buttonSchowArchiveGames_Click(object sender, EventArgs e)
        {
            ArchiveGames archiveGames = new ArchiveGames(gameBoardForSeriliazation);
            archiveGames.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deserelazation();
        }

        private void Serialization(List<int[,]> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText("data.json", json);
        }

        private void Deserelazation()
        {
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                gameBoardForSeriliazation = JsonConvert.DeserializeObject<List<int[,]>>(json);
            }
            else
            {
                // создание нового файла
                File.Create("data.json").Close();
            }
        }
    }
}