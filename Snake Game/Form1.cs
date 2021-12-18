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
            trackBar.Enabled = false;
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

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            //Change interval of timer with the value of speed trackbar
            timer1.Interval = 501 - (5 * trackBar.Value);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
        }

        private void move()
        {
            Point point = new Point(0, 0);

            //Loop for moving each part of snake according to direction
            for (int i = 0; i < snakeSize; i++)
            {
                if(i == 0)
                {
                    point = snakeParts[i].Location;
                    if (direction == "Left")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X - 15, snakeParts[i].Location.Y);
                    }
                    if (direction == "Right")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X + 15, snakeParts[i].Location.Y);
                    }
                    if (direction == "Top")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X, snakeParts[i].Location.Y - 15);
                    }
                    if (direction == "Down")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X, snakeParts[i].Location.Y + 15);
                    }
                }
                else
                {
                    Point newPoint = snakeParts[i].Location;
                    snakeParts[i].Location = point;
                    point = newPoint;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Up) && direction != "Down" && changingDirection != true){
                direction = "Top";
                changingDirection = true;
            }
            if (keyData == (Keys.Up) && direction != "Down" && changingDirection != true)
            {
                direction = "Top";
                changingDirection = true;
            }
            if (keyData == (Keys.Up) && direction != "Down" && changingDirection != true)
            {
                direction = "Top";
                changingDirection = true;
            }
            if (keyData == (Keys.Up) && direction != "Down" && changingDirection != true)
            {
                direction = "Top";
                changingDirection = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
