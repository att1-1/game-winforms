using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GameModel
    {
        public int Score { get; private set; }
        public bool IsGameOver { get; private set; }
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int Score { get; set; }

        public GameModel()
        {
            IsGameOver = false;
            PlayerX = 0;
            PlayerY = 0;
            Score = 0;
        }

        public void IncreaseScore()
        {
            Score++;
        }

        public void MovePlayerLeft()
        {
            // Логика перемещения игрока влево
            PlayerX -= 5; // Примерный шаг движения влево
        }

        public void MovePlayerRight()
        {
            // Логика перемещения игрока вправо
            PlayerX += 5; // Примерный шаг движения вправо
        }
    }
}
