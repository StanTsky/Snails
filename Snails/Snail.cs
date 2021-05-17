using System;
using System.Drawing;

namespace Snails
{
    class Snail
    {
        Image image;        
        public int X { get; set; }
        public int Y { get; set; }
        static Random r = new Random();

        public Snail()
        {
            X = 0; Y = 0;
            image = Properties.Resources.snail4;

        }
        public Snail(int x, int y, Image image)
        {
            X = x;
            Y = y;
            this.image = image;
        }

        public void Move()
        {
            X += r.Next(5, 25);
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, X - image.Width/2, Y-image.Height/2);

        }

    }
    class TurboSnail:Snail
    {

    }
}
