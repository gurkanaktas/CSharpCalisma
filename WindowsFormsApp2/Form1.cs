using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class pingpong : Form
    {
        int playerHiz = 7;

        int p1Hiz;
        int p2Hiz;

        int p1Puan;
        int p2Puan;
        
        int TopHizX = 3;
        int TopHizY = -3;

        bool pause = false;


        public pingpong()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!pause)
            {

                top.Location = new Point(top.Location.X + TopHizX, top.Location.Y + TopHizY);
                player1.Location = new Point(player1.Location.X + p1Hiz, player1.Location.Y);
                player2.Location = new Point(player2.Location.X + p2Hiz, player2.Location.Y);
            }
            if(top.Location.Y < 0)
            {
                p1Puan++;
                top.Location = new Point(this.Width / 2, this.Height / 2);
            }
            if(top.Location.Y > this.Height)
            {
                p2Puan++;
                top.Location = new Point(this.Width / 2, this.Height / 2);
            }

            if(top.Location.X > player1.Location.X && top.Location.X + top.Width < player1.Location.X + player1.Width && top.Location.Y + top.Height > player1.Location.Y){
                TopHizY *= -1;
            }
            if (top.Location.X > player2.Location.X && top.Location.X + top.Width < player2.Location.X + player2.Width && top.Location.Y < player2.Location.Y + player2.Height)
            {
                TopHizY *= -1;
            }
            if(top.Location.X < 0)
            {
                TopHizX *= -1;
            }
            if(top.Location.X + top.Width > this.Width)
            {
                TopHizX *= -1;
            }


            p1score.Text = p1Puan.ToString();
            p2score.Text = p2Puan.ToString();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                p1Hiz = playerHiz;

            } else if (e.KeyCode == Keys.Left)
            {
                p1Hiz = -playerHiz;

            }
            else if (e.KeyCode == Keys.D)
            {
                p2Hiz = playerHiz;

            }
            else if (e.KeyCode == Keys.A)
            {
                p2Hiz = -playerHiz;

            }
            else if(e.KeyCode == Keys.Down)
            {   

                TopHizX = 6;
                TopHizY = -6;
            }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                p1Hiz = 0;

            }
            else if (e.KeyCode == Keys.Left)
            {
                p1Hiz = 0;

            }
            else if (e.KeyCode == Keys.D)
            {
                p2Hiz = 0;

            }
            else if (e.KeyCode == Keys.A)
            {
                p2Hiz = 0;

            }
            else if( e.KeyCode == Keys.P)
            {
                if (!pause)
                {
                    pause = true;
                }
                else if (pause)
                {
                    pause = false;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                TopHizX = 3;
                TopHizY = -3;
            }

        }

        private void pingpong_Load(object sender, EventArgs e)
        {

        }
    }
}
