using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {

        // ========= My Snake Default =========
        PictureBox[] snakeBody;
        int snakeLenght = 5;
        Point location = new Point(120, 120);
        string direction = "Right";
        bool changeDirection = false;

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
            snakeBody = null;
            scoreLabel.Text = "0";
            snakeLenght = 5;
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
            snakeBody = new PictureBox[snakeLenght];

            // ========= A Loop For Increasing The Snake =========

            for (int i = 0; i < snakeLenght; i++)
            {
                snakeBody[i] = new PictureBox();
                snakeBody[i].Size = new Size(15, 15);
                snakeBody[i].BackColor = Color.HotPink;
                snakeBody[i].BorderStyle = BorderStyle.FixedSingle;
                snakeBody[i].Location = new Point(location.X-(15*i), location.Y);
                gamePanel.Controls.Add(snakeBody[i]);
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
                for(int i = 0;i < snakeLenght; i++)
                {
                    if(snakeBody[i].Location == new Point(Xrand, Yrand))
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
            for (int i = 0; i < snakeLenght; i++)
            {
                if(i == 0)
                {
                    point = snakeBody[i].Location;
                    if (direction == "Left")
                    {
                        snakeBody[i].Location = new Point(snakeBody[i].Location.X - 15, snakeBody[i].Location.Y);
                    }
                    if (direction == "Right")
                    {
                        snakeBody[i].Location = new Point(snakeBody[i].Location.X + 15, snakeBody[i].Location.Y);
                    }
                    if (direction == "Top")
                    {
                        snakeBody[i].Location = new Point(snakeBody[i].Location.X, snakeBody[i].Location.Y - 15);
                    }
                    if (direction == "Down")
                    {
                        snakeBody[i].Location = new Point(snakeBody[i].Location.X, snakeBody[i].Location.Y + 15);
                    }
                }
                else
                {
                    Point newPoint = snakeBody[i].Location;
                    snakeBody[i].Location = point;
                    point = newPoint;
                }
            }
            changeDirection = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Up) && direction != "Down" && changeDirection != true){
                direction = "Top";
                changeDirection = true;
            }

            if (keyData == (Keys.Down) && direction != "Top" && changeDirection != true)
            {
                direction = "Down";
                changeDirection = true;
            }
            if (keyData == (Keys.Left) && direction != "Right" && changeDirection != true)
            {
                direction = "Left";
                changeDirection = true;
            }
            if (keyData == (Keys.Right) && direction != "Left" && changeDirection != true)
            {
                direction = "Right";
                changeDirection = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
