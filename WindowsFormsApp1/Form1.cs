using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly int playerSpeed = 7;
        private int enemyOneSpeed = 5;
        private int enemyTwoSpeed = 3;
        private int force;
        private bool goLeft, goRight, jumping, isGameOver;

        private int horizontalSpeed = 5;

        private int jumpSpeed;
        private int score;
        private int verticalSpeed = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}