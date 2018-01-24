using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class UltaMegaBuffSuperMotorShip : MotorShip
    {
        private bool pipe;
        private bool boats;
        private Color selfColor;

        public UltaMegaBuffSuperMotorShip(int maxSpeed, int maxCountPassenger, double weight, Color color,
            bool pipe, bool boats,Color selfColor) : base(maxSpeed, maxCountPassenger, weight, color)
        {
            this.pipe = pipe;
            this.boats = boats;
			this.selfColor = selfColor;
        }

        public UltaMegaBuffSuperMotorShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 7)
            {
                pipe = Convert.ToBoolean(strs[4]);
                boats = Convert.ToBoolean(strs[5]);
                selfColor = Color.FromName(strs[6]);
            }
        }

        public void SetDopColor(Color color)
        {
            selfColor = color;
        }


        protected override void drawLightShip(Graphics g)
        {
            base.drawLightShip(g);
            Brush brush1 = new SolidBrush(selfColor);

            g.FillEllipse(brush1, startX + 40, startY + 11, 15, 15);

            g.FillRectangle(brush1, startX + 5, startY + 8, 15, 15);

            g.FillEllipse(brush1, startX + 60, startY + 11, 15, 15);

            Brush brus2 = new SolidBrush(Color.Black);

            g.FillRectangle(brus2, startX - 5, startY + 40, 100, 5);
            g.FillRectangle(brus2, startX + 85, startY + 13, 20, 20);
            Brush brush1337 = new SolidBrush(selfColor);
            g.FillRectangle(brush1337, startX + 80, startY - 5, 20, 15);
            Brush brus3 = new SolidBrush(Color.Red);

            g.FillEllipse(brus3, startX + 105, startY + 17, 20, 10);
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" +
                ColorBody.Name + ";" + pipe + ";" + boats + ";" + selfColor.Name;
        }
    }
}
