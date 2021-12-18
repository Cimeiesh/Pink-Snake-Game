using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        //========= Database Variables =========
        static String path = Path.GetFullPath(Environment.CurrentDirectory);
        static String dataBaseName = "data.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + dataBaseName + "; Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //========= Cleaning The Game For A New Game =========
            gamePanel.Controls.Clear();
            snakeBody = null;
            myScore.Text = "0";
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
            stopGame();
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

            //========= Check If Snake Eats The Food =========
            if (snakeBody[0].Location == foodLocation)
            {
                eatFood();
                drawFood();
            }

            if(snakeBody[0].Location.X < 0 || snakeBody[0].Location.X >=570 || snakeBody[0].Location.Y < 0 || snakeBody[0].Location.Y >= 450)
            {
                stopGame();
            }

            for(int i = 3; i < snakeLenght; i++)
            {
                if(snakeBody[0].Location == snakeBody[i].Location)
                {
                    stopGame();
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

        private void eatFood()
        {
            snakeLenght++;

            //========= Incremented the snake =========
            PictureBox[] currentSnake = snakeBody;
            gamePanel.Controls.Clear();
            snakeBody = new PictureBox[snakeLenght];

            for(int i = 0; i < snakeLenght; i++)
            {
                snakeBody[i] = new PictureBox();
                snakeBody[i].Size = new Size(15, 15);
                snakeBody[i].BackColor = Color.HotPink;
                snakeBody[i].BorderStyle = BorderStyle.FixedSingle;

                if (i == 0)
                {
                    snakeBody[i].Location = foodLocation;
                }
                else
                {
                    snakeBody[i].Location = currentSnake[i-1].Location;
                }
                gamePanel.Controls.Add(snakeBody[i]);
            }

            //========= Incremented the Score =========
            int currentScore = int.Parse(myScore.Text);
            int newScore = currentScore + 10;
            myScore.Text = newScore + "";
        }

        private void stopGame()
        {
            timer1.Stop();
            startButton.Enabled = true;
            trackBar.Enabled = true;
            stopButton.Enabled = false;
            nameBox.Enabled = true;

            Label gameOver = new Label();
            gameOver.Text = "Game \n Over";
            gameOver.ForeColor = Color.DarkRed;
            gameOver.Font = new Font("Arial", 100, FontStyle.Bold);
            gameOver.Size = gameOver.PreferredSize;
            gameOver.TextAlign = ContentAlignment.MiddleLeft;
            

            int X = gamePanel.Width / 2 - gameOver.Width / 2;
            int Y = gamePanel.Height / 2 - gameOver.Height / 2;
            gameOver.Location = new Point(X, Y);

            gamePanel.Controls.Add(gameOver);
            gameOver.BringToFront();


            SaveToDatabase();
            updateScoreBoard();
        }

        private void SaveToDatabase()
        {
            string query = "INSERT INTO scores(Date,Name,Scores) VALUES(@Date,@Name,@Scores);";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = nameBox.Text;
                command.Parameters.Add("@Scores", SqlDbType.Int).Value = myScore.Text;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    throw;
                }
            }
        }

        private void updateScoreBoard()
        {
            string query = "SELECT Date, Name, Scores FROM scores";

                using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                var ds = new DataSet();
                adapter.Fill(ds);

                scoreBoardView.DataSource = ds.Tables[0];

                scoreBoardView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                scoreBoardView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                scoreBoardView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                scoreBoardView.Sort(this.scoreBoardView.Columns[0], ListSortDirection.Descending);
            }
        }
    }
}
