using HomeworkNumber4.Properties;
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

namespace HomeworkNumber4
{
    public partial class Form3 : Form
    {
        private SoundPlayer _soundPlayer;
        
        string proměnn;
        public Form3(string proměnná)
        {
            InitializeComponent();
            proměnn = proměnná;
            _soundPlayer = new SoundPlayer(Resources.meme);
            DoubleBuffered = true;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            MessageBox.Show("Pro vypnutí písničky zmáčkni P");
        }
        Image obrazek;
        int x = 130;
        int y = 150;
        string hudba = "nehraje1";
        int b = 5;
        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            if (proměnn == "Auto")
            {
                obrazek = Resources.E3;
            }
            else if (proměnn == "Mašinka")
            {
                obrazek = Resources.train;
            }
            Graphics k = e.Graphics;

            Rectangle image = new Rectangle(x, y, 50, 50);
            Rectangle Obstacle = new Rectangle(100, 100, 1, 150);//záčatek startu dolu
            Rectangle Obstacle2 = new Rectangle(100, 100, 100, 1);
            Rectangle Obstacle3 = new Rectangle(100, 250, 100, 1);
            Rectangle Obstacle4 = new Rectangle(200, 250, 400, 1);//spodní dlouhá
            Rectangle Obstacle6 = new Rectangle(200, 100, 1, 150);//start
            Rectangle Obstacle7 = new Rectangle(200, 100, 400, 1);//horní dlouhá
            Rectangle Obstacle8 = new Rectangle(600, 100, 100, 1);
            Rectangle Obstacle9 = new Rectangle(700, 100, 1, 150);
            Rectangle Obstacle10 = new Rectangle(600, 250, 1, 150);
            Rectangle Obstacle11 = new Rectangle(700, 250, 1, 150);
            Rectangle Obstacle12 = new Rectangle(600, 400, 100, 1);
            Rectangle Obstacle5 = new Rectangle(600, 325, 100, 1);//finish




            k.DrawRectangle(Pens.Transparent, image);
            k.DrawRectangle(Pens.Blue, Obstacle);
            k.DrawRectangle(Pens.Blue, Obstacle2);
            k.DrawRectangle(Pens.Blue, Obstacle2);
            k.DrawRectangle(Pens.Blue, Obstacle3);
            k.DrawRectangle(Pens.Blue, Obstacle4);
            k.DrawRectangle(Pens.Red, Obstacle5);
            k.DrawRectangle(Pens.Red, Obstacle6);
            k.DrawRectangle(Pens.Blue, Obstacle7);
            k.DrawRectangle(Pens.Blue, Obstacle8);
            k.DrawRectangle(Pens.Blue, Obstacle9);
            k.DrawRectangle(Pens.Blue, Obstacle10);
            k.DrawRectangle(Pens.Blue, Obstacle11);
            k.DrawRectangle(Pens.Blue, Obstacle12);

            k.DrawImage(obrazek, x, y, 51, 51);

            if (image.IntersectsWith(Obstacle) || image.IntersectsWith(Obstacle2) || image.IntersectsWith(Obstacle3) || image.IntersectsWith(Obstacle4) || image.IntersectsWith(Obstacle7) || image.IntersectsWith(Obstacle8) || image.IntersectsWith(Obstacle9) || image.IntersectsWith(Obstacle10) || image.IntersectsWith(Obstacle11) || image.IntersectsWith(Obstacle12))
            {
                x = 130;
                y = 150;
                if (hudba == "nebude nikdy hrát")
                {

                }
                else
                {
                    hudba = "nehraje1";
                }
                _soundPlayer.Stop();
                MessageBox.Show("Zkus to znovu!");
            }

            if (image.IntersectsWith(Obstacle5))
            {
                x = 130;
                y = 150;
                hudba = "nehraje1";
                _soundPlayer.Stop();
                MessageBox.Show("Zvládnul jsi to!");
                Hide();
                Form1 firstForm = new Form1();
                firstForm.ShowDialog();
                Close();
            }
            Invalidate();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                x += b;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= b;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += b;
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= b;
            }
            
            if (hudba == "nehraje1")
            {
                _soundPlayer.Play();
                hudba = "hraje";
            }
            if (e.KeyCode == Keys.P)
            {
                _soundPlayer.Stop();
                hudba = "nebude nikdy hrát";
            }
        }
    }
}
