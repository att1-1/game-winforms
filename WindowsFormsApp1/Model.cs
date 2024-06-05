using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1
    {
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Счет: " + score;

            player.Top += jumpSpeed;

            if (goLeft) player.Left -= playerSpeed;

            if (goRight) player.Left += playerSpeed;

            if (jumping && force < 0) jumping = false;

            if (jumping)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in Controls)
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if ((x.Name == "horizontalPlatform" && goLeft == false) ||
                                (x.Name == "horizontalPlatform" && goRight == false))
                                player.Left -= horizontalSpeed;
                        }

                        x.BringToFront();
                    }

                    AddCoins(x);

                    IfIntersectEnemy(x);
                }

            MoveLogic();


            IfFallDown();


            IfFinish();
        }

        private void horizontalPlatform_Click(object sender, EventArgs e)
        {
        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            SetScore();
            foreach (Control x in Controls)
                if (x is PictureBox && x.Visible == false)
                    x.Visible = true;

            //сброс позиции игрока, платформ и врагов
            player.Left = 48;
            player.Top = 682;
            player.BackColor = Color.Transparent;

            enemyOne.Left = 465;
            enemyTwo.Left = 351;

            horizontalPlatform.Left = 279;
            verticalPlatform.Top = 581;


            gameTimer.Start();
        }
    }
}