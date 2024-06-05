using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GameView : Form
    {
        private PictureBox player;
        private Label txtScore;
        private GameModel model;
        private GameController controller;

        public GameView(GameModel model, GameController controller)
        {
            this.model = model;
            this.controller = controller;
            InitializeComponents();
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
        }

        private void InitializeComponents()
        {
            player = new PictureBox();
            txtScore = new Label();

            player.Size = new Size(50, 50);
            player.BackColor = Color.Red;
            txtScore.Text = "Счет: 0";
            txtScore.Location = new Point(10, 10);

            Controls.Add(player);
            Controls.Add(txtScore);
        }

        public void UpdateView()
        {
            player.Location = new Point(model.PlayerX, model.PlayerY);
            txtScore.Text = "Счет: " + model.Score;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                controller.MovePlayerLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                controller.MovePlayerRight();
            }
            else if (e.KeyCode == Keys.Space)
            {
                controller.Jump();
            }

            UpdateView();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                controller.EndJump();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameView
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "GameView"; 
            this.Text = "MyGame)";
            this.ResumeLayout(false);
    }
}