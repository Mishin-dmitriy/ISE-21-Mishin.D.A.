using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class MotorShip : Ship
    {
        public override int MaxSpeed
        {
            get { return base.MaxSpeed; }
            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;		
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get { return base.MaxCountPassengers; }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get { return base.Weight; }
            protected set
            {
                if(value>500 && value < 1500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public MotorShip(int maxSpeed,int maxCountPassenger,double weight,Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassenger;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random r = new Random();
            this.startX = r.Next(10, 200);
            this.startY = r.Next(10, 200);
        }

        public MotorShip(string info)
        {
            string[] strs = info.Split(';');
            if(strs.Length >= 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);

            }
            this.countPassengers = 0;
            Random r = new Random();
            startX = r.Next(10, 200);
            startY = r.Next(10, 200);
        }

        public override void moveShip(Graphics g)
        {
            startX +=
                (MaxSpeed * 50 / (float)Weight) /
                    (countPassengers == 0 ? 1 : countPassengers);
            drawShip(g);
        }

        public override void drawShip(Graphics g)
        {
			drawLightShip(g);
        }

        protected virtual void drawLightShip(Graphics g)
        {
            Pen pen = new Pen(ColorBody);

            Brush brush1 = new SolidBrush(ColorBody);
            g.FillRectangle(brush1, startX, startY, 90, 40);
            Brush brush2 = new SolidBrush(Color.Black);
            g.FillEllipse(brush2, startX + 3, startY + 33, 20, 20);
            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, startX + 65, startY + 33, 20, 20);
            Brush br = new SolidBrush(ColorBody);
            Pen pen2 = new Pen(Color.Black);

        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" +
                Weight + ";" + ColorBody.Name;
        }
    }
}
