using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuropaMenu;
namespace Level3
{
    public partial class Level3 : Form
    {
        bool goLeft, goRight;
        int playerSpeed = 12;
        int enemySpeed = 12;
        int score = 0;
        int enemyBulletTimer = 300;

        PictureBox[] enemyArray;

        bool shooting;
        bool isGameOver;

        public Level3()
        {
            InitializeComponent();
            gameSetup();

        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goLeft)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight)
            {
                Player.Left += playerSpeed;
            }

            enemyBulletTimer -= 10;

            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 250;
                EnemyBullet("enemyBullet1");
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Griff")
                {
                    x.Left += enemySpeed;
                    if (x.Left > 730)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }

                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        gameOver("The Delorean has taken too much damage.  \n Lucky for you, it's a time machine! \n Press any key to start over and try again!");
                    }

                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "Bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                score += 1;
                                shooting = false;
                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "Bullet")
                {
                    x.Top -= 20;

                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemyBullet1")
                {
                    x.Top += 20;
                    if (x.Top > 620)
                    {
                        this.Controls.Remove(x);
                    }
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("The Delorean has taken too much damage.  \n Lucky for you, it's a time machine! \n Press any key to start over and try again!");
                    }
                }
            }
            if (score > 8)
            {
                enemySpeed = 16;
            }
            if (score == enemyArray.Length)
            {
                gameOver("That was close.  Let's see what this planet has to offer.");
                button2.Visible = true;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                makeBullet("Bullet");
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeAll();
                gameSetup();
            }
        }

        private void makeEnemies()
        {
            enemyArray = new PictureBox[18];

            int left = 0;

            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = new PictureBox();
                enemyArray[i].Size = new Size(60, 50);
                enemyArray[i].Image = Properties.Resources.Griff;
                enemyArray[i].Top = 5;
                enemyArray[i].Tag = "Griff";
                enemyArray[i].Left = left;
                enemyArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(enemyArray[i]);
                left = left - 80;
            }


        }

        private void gameSetup()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            isGameOver = false;

            enemyBulletTimer = 300;
            enemySpeed = 12;
            shooting = false;
            makeEnemies();
            GameTimer.Start();
        }
        private void gameOver(string message)
        {
            isGameOver = true;
            GameTimer.Stop();
            txtScore.Text = "Score: " + score + " " + message;
        }

        private void removeAll()
        {
            foreach (PictureBox i in enemyArray)
            {
                this.Controls.Remove(i);
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Bullet" || (string)x.Tag == "enemyBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void makeBullet(string BulletTag)
        {
            PictureBox Bullet = new PictureBox();
            Bullet.Image = Properties.Resources.Bullet;
            Bullet.Size = new Size(5, 20);
            Bullet.Tag = BulletTag;
            Bullet.Left = Player.Left + Player.Width / 2;

            if ((string)Bullet.Tag == "Bullet")
            {
                Bullet.Top = Player.Top - 20;
            }

            //Change back to white 
            //else if ((string)Bullet.Tag == "enemyBullet")
            //{
            //    Bullet.Top = -100;
            //}

            this.Controls.Add(Bullet);
            Bullet.BringToFront();

        }
        private void EnemyBullet(string enemyBullettag)
        {
            PictureBox EnemyBullet1 = new PictureBox();
            EnemyBullet1.Image = Properties.Resources.enemyBullet1;
            EnemyBullet1.Size = new Size(5, 20);
            EnemyBullet1.Tag = enemyBullettag;
            EnemyBullet1.Left = Player.Left + Player.Width / 2;

            if ((string)EnemyBullet1.Tag == "enemyBullet")
            {
                EnemyBullet1.Top = -100;
            }
            this.Controls.Add(EnemyBullet1);
            EnemyBullet1.BringToFront();

        }

        private void Level3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EuropaMenu.EuropaMenu().Show();
            CloseMenu();
        }

        public void CloseMenu()
        {
            this.Close();
        }
    }
}
