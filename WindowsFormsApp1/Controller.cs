using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1
    {
        private void MoveLogic()
        {
            horizontalPlatform.Left -= horizontalSpeed;

            if (horizontalPlatform.Left < 0 ||
                horizontalPlatform.Left + horizontalPlatform.Width > ClientSize.Width ||
                horizontalPlatform.Left > 480)
                horizontalSpeed = -horizontalSpeed;

            verticalPlatform.Top += verticalSpeed;

            if (verticalPlatform.Top < 200 || verticalPlatform.Top > 581) verticalSpeed = -verticalSpeed;


            enemyOne.Left -= enemyOneSpeed;

            if (enemyOne.Left < pictureBox5.Left ||
                enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
                enemyOneSpeed = -enemyOneSpeed;

            enemyTwo.Left += enemyTwoSpeed;

            if (enemyTwo.Left < pictureBox2.Left ||
                enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
                enemyTwoSpeed = -enemyTwoSpeed;
        }
    }

    public partial class Form1
    {
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.Space when jumping == false:
                    jumping = true;
                    break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;

            if (e.KeyCode == Keys.Right) goRight = false;

            if (jumping) jumping = false;

            if (e.KeyCode == Keys.Enter && isGameOver) RestartGame();
        }
    }
}