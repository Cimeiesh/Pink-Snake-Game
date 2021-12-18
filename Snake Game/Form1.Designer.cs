namespace Snake_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.myScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.scoreBoardView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardView)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sylfaen", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.LightPink;
            this.Title.Location = new System.Drawing.Point(198, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(501, 70);
            this.Title.TabIndex = 0;
            this.Title.Text = "PINK SNAKE GAME";
            this.Title.UseMnemonic = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Black;
            this.gamePanel.Location = new System.Drawing.Point(15, 256);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(570, 450);
            this.gamePanel.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.startButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Location = new System.Drawing.Point(15, 192);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(280, 58);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.stopButton.Location = new System.Drawing.Point(305, 192);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(280, 58);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "STOP GAME";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(15, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 83);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "SPEED";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.MistyRose;
            this.nameBox.Location = new System.Drawing.Point(19, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(175, 20);
            this.nameBox.TabIndex = 6;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(217, 35);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(350, 45);
            this.trackBar.TabIndex = 5;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 50;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SETTINGS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightPink;
            this.panel3.Controls.Add(this.scoreBoardView);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(594, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 513);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "SCORE BOARD";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Controls.Add(this.myScore);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(594, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 83);
            this.panel5.TabIndex = 9;
            // 
            // myScore
            // 
            this.myScore.AutoSize = true;
            this.myScore.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myScore.Location = new System.Drawing.Point(170, 17);
            this.myScore.Name = "myScore";
            this.myScore.Size = new System.Drawing.Size(44, 51);
            this.myScore.TabIndex = 13;
            this.myScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "SCORE:";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(573, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "MADE BY CIMEIESH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightPink;
            this.label6.Location = new System.Drawing.Point(17, 714);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "1. Eat the green food to earn 10 points.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightPink;
            this.label8.Location = new System.Drawing.Point(17, 730);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "2. You die if you hit the wall or snakebody.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightPink;
            this.label9.Location = new System.Drawing.Point(242, 714);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "3. If you eat red food you lose 35 points.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LightPink;
            this.label10.Location = new System.Drawing.Point(242, 730);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "4. If you eat blue food you earn 30 points.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LightPink;
            this.label11.Location = new System.Drawing.Point(462, 730);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "6. Use the arrow keys to move your snake.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.LightPink;
            this.label12.Location = new System.Drawing.Point(462, 714);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "5. You will reset the game if you press Stop Game.";
            // 
            // scoreBoardView
            // 
            this.scoreBoardView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.scoreBoardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoardView.Location = new System.Drawing.Point(15, 49);
            this.scoreBoardView.Name = "scoreBoardView";
            this.scoreBoardView.RowHeadersVisible = false;
            this.scoreBoardView.Size = new System.Drawing.Size(250, 443);
            this.scoreBoardView.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 768);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label myScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView scoreBoardView;
    }
}

