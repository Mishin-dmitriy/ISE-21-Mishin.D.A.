using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public interface ITransport
    {
        void moveShip(Graphics g);
        void drawShip(Graphics g);
        void sePosition(int x, int y);
        void loadPassenger(int count);
        int getPassenger();
        void setMainColor(Color color);
    }
}
