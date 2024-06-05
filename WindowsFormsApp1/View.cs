using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1
    {
        private void AddCoins(Control x)
        {
            if ((string)x.Tag != "coin" || !x.Visible) return;
            if (!player.Bounds.IntersectsWith(x.Bounds)) return;
            x.Visible = false;
            score++;
        }
    }

    public partial class Form1
    {
        private void IfIntersectEnemy(Control x)
        {
            if ((string)x.Tag != "enemy") return;
            if (!player.Bounds.IntersectsWith(x.Bounds)) return;
            txtScore.Text = "Счет: " + score + Environment.NewLine + "Вы были съедны. Прощайте!";
            gameTimer.Stop();
            isGameOver = true;
        }
    }

    public partial class Form1
    {
        private void IfFinish()
        {
            if (!player.Bounds.IntersectsWith(door.Bounds) || score != 20) return;
            gameTimer.Stop();
            isGameOver = true;
            txtScore.Text = "Score: " + score + Environment.NewLine + "Ваш путь окончен!";
        }

        private void IfFallDown()
        {
            if (player.Top + player.Height <= ClientSize.Height + 50) return;
            gameTimer.Stop();
            isGameOver = true;
            txtScore.Text = "Счет: " + score + Environment.NewLine + "Падение оказалось смертельно для вас!";
        }
    }

    public partial class Form1
    {
        private void SetScore()
        {
            txtScore.Text = "Счет: " + score;
        }
    }
}