using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;

namespace Snails
{
    public partial class Form1 : Form
    {
        const int StartX = 50;
        const int FinishX = 600;

        //const int StartY = 50;
        List<Snail> snails=new List<Snail>();
        SoundPlayer vroom = new SoundPlayer(Properties.Resources.vroom);

        public Form1()
        {
            InitializeComponent();
            //snails = new List<Snail>();
            //for (int i = 0; i < 3; i++)
            CreateSnails();
        }

        void CreateSnails()
        {
            snails.Clear();

            Snail s = new Snail(StartX, 50, Properties.Resources.snail1);
            snails.Add(s);

            s = new Snail(StartX, 150, Properties.Resources.snail2);
            snails.Add(s);

            s = new Snail(StartX, 250, Properties.Resources.snail3);
            snails.Add(s);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Snail s in snails)
            {
                s.Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Snail s in snails)
            {
                s.Move();
                if (s.X > FinishX)
                {
                    timer1.Stop();
                }
            }

            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSnails();
            vroom.Play();
            timer1.Start();
        }
    }
}
