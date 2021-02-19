using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarsMenu;
namespace Level2
{
    public partial class Level2 : Form
    {
        bool goLeft, goRight;
        int playerSpeed = 15;
        int enemySpeed = 18;
        int score = 0;
        int enemyBulletTimer = 300;

        PictureBox[] enemyArray;

        bool shooting;
        bool isGameOver;

        public Level2()
        {
            InitializeComponent();
            gameSetup();

        }

        private void MaingameTimer(object sender, EventArgs e)
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
                enemyBulletTimer = 300;
                EnemyBullet("enemyBullet1");
            }
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Needles")
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
                enemySpeed = 20;
            }
            if (score == enemyArray.Length)
            {
                gameOver("That was close.  Let's see what this planet has to offer.");
                NextLvL.Visible = true;
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
            enemyArray = new PictureBox[15];

            int left = 0;

            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = new PictureBox();
                enemyArray[i].Size = new Size(60, 50);
                enemyArray[i].Image = Properties.Resources.Needles;
                enemyArray[i].Top = 5;
                enemyArray[i].Tag = "Needles";
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
            enemySpeed = 18;
            shooting = false;
            makeEnemies();
            Gametime.Start();
        }
        private void gameOver(string message)
        {
            isGameOver = true;
            Gametime.Stop();
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
        private void EnemyBullet(string enemybullettag)
        {
            PictureBox EnemyBullet1 = new PictureBox();
            EnemyBullet1.Image = Properties.Resources.enemyBullet1;
            EnemyBullet1.Size = new Size(5, 20);
            EnemyBullet1.Tag = enemybullettag;
            EnemyBullet1.Left = Player.Left + Player.Width / 2;

            if ((string)EnemyBullet1.Tag == "enemyBullet")
            {
                EnemyBullet1.Top = -100;
            }
            this.Controls.Add(EnemyBullet1);
            EnemyBullet1.BringToFront();

        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }

        private void NextLvL_Click(object sender, EventArgs e)
        {
            new marsMenu().Show();
           
            closeGame();
        }

        public void closeGame()
        {
            this.Close();
        }
    }
 }
