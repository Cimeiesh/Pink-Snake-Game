using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {

        // ========= My Snake Default =========
        PictureBox[] snakeParts;
        int snakeSize = 5;
        Point location = new Point(120, 120);
        string direction = "Right";
        bool changingDirection = false;

        //========= My Food Default =========
        PictureBox food = new PictureBox();
        Point foodLocation = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //========= Cleaning The Game For A New Game =========
            gamePanel.Controls.Clear();
            snakeParts = null;
            scoreLabel.Text = "0";
            snakeSize = 5;
            direction = "Right";
            location = new Point(120, 120);

            //========= Start My Game =========
            drawSnake();
            drawFood();

            timer1.Start();

            //========= Disable Setting and Start =========
            trackBar1.Enabled = false;
            startButton.Enabled = false;
            nameBox.Enabled = false;

            //========= Enable Stop Button =========
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void drawSnake()
        {
            snakeParts = new PictureBox[snakeSize];

            // ========= A Loop For Increasing The Snake =========

            for (int i = 0; i < snakeSize; i++)
            {
                snakeParts[i] = new PictureBox();
                snakeParts[i].Size = new Size(15, 15);
                snakeParts[i].BackColor = Color.HotPink;
                snakeParts[i].BorderStyle = BorderStyle.FixedSingle;
                snakeParts[i].Location = new Point(location.X-(15*i), location.Y);
                gamePanel.Controls.Add(snakeParts[i]);
            }
        }

        private void drawFood()
        {
            Random rnd = new Random();
            int Xrand = rnd.Next(38) * 15;
            int Yrand = rnd.Next(30) * 15;

            bool snakeEat = true;

            //========= Check If Snake Eats The Food =========
            while (snakeEat)
            {
                for(int i = 0;i < snakeSize; i++)
                {
                    if(snakeParts[i].Location == new Point(Xrand, Yrand))
                    {
                        Xrand = rnd.Next(38) * 15;
                        Yrand = rnd.Next(30) * 15;
                    }
                    else
                    {
                        snakeEat = false;
                    }
                }
            }

            if (snakeEat == false)
            {
                foodLocation = new Point(Xrand, Yrand);
                food.Size = new Size(15, 15);
                food.BackColor = Color.LimeGreen;
                food.BorderStyle = BorderStyle.FixedSingle;
                food.Location = foodLocation;
                gamePanel.Controls.Add(food);
            }

        }
    }
}
