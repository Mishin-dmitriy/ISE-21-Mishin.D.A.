using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{

    public abstract class Ship : ITransport
    {
        protected float startX;
        protected float startY;
        protected int countPassengers;
        public virtual int MaxCountPassengers { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }
        public Color ColorBody { protected set; get; }
        public virtual double Weight { protected set; get; }


        public abstract void drawShip(Graphics g);

        public abstract string getInfo();

        public int getPassenger()
        {
            int count = countPassengers;
            countPassengers = 0;
            return count;
        }

        public void loadPassenger(int count)
        {
            if (countPassengers + count <= MaxCountPassengers)
            {
                countPassengers += count;
            }
        }

        public abstract void moveShip(Graphics g);

        public void sePosition(int x, int y)
        {
            startX = x;
            startY = y;
        }

        public void setMainColor(Color color)
        {
            ColorBody = color;
        }
    }
}
