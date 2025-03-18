using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mafinka
{
    public partial class mafinka : Form
    {

        private Point pos;
        private bool dragging, lose = false;
        private int countCoins = 0; 


        public mafinka()
        {
            InitializeComponent();


            BG1.MouseDown += MouseClickDown;
            BG1.MouseUp += MouseClickUp;
            BG1.MouseMove += MouseClickMove;

            BG2.MouseDown += MouseClickDown;
            BG2.MouseUp += MouseClickUp;
            BG2.MouseMove += MouseClickMove;


            labelLose.Visible = false;
            Restart.Visible = false;

            KeyPreview = true;
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X; 
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + BG1.Top);
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
                this.Close();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 20;
            int speedcoin = 10;
            BG1.Top += speed;
            BG2.Top += speed;

            int carspeed = 10;
            enemy1.Top += carspeed;
            enemy2.Top += carspeed;
            enemy3.Top += carspeed;


            coin.Top += speedcoin;

            if (BG1.Top >= 650)
            {
                BG1.Top = 0;
                BG2.Top = -650;
            }

            if (coin.Top >= 650)
            {
                coin.Top = -100;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);
            }
            
            if (enemy2.Top >= 650) 
            { 
                enemy2.Top = -200;
                Random rand = new Random();
                enemy2.Left = rand.Next(150, 300);
            }
            if (enemy3.Top >= 650) 
            { 
                enemy3.Top = -400;
                Random rand = new Random();
                enemy3.Left = rand.Next(300, 600);
            }

            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                Restart.Visible = true;
                lose = true;
            }

            if (car.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text= "Coin: "+ countCoins.ToString();

                coin.Top = -100;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(lose) return;

            int speed = 15;

            if((e.KeyCode  == Keys.Left || e.KeyCode == Keys.A) && car.Left > 150)
            {
                car.Left -= speed;
            }
                    

            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && car.Right < 700)
            {
                car.Left += speed;
            }
                    
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            enemy3.Top = -600;
            labelLose.Visible = false;
            Restart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countCoins = 0;
            labelCoins.Text = "Coin: 0";
            coin.Top = -600;
        }
    }
}
