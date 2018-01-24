using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Parking
	{
		ClassArray<ITransport> parking;

		int countPlaces = 20;
		int placeSizeWidth = 210;
		int placeSizeHeight = 80;

		public Parking()
		{
			parking = new ClassArray<ITransport>(countPlaces, null);
		}

		public int PutShipInParking(ITransport ship)
		{
			return parking + ship;
		}

		public ITransport GetShipInParking(int ticket)
		{
			return parking - ticket;
		}

		public void Draw(Graphics g,int width,int height)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
			for(int i = 0; i < countPlaces / 5; i++)
			{
				for(int j = 0; j <6; ++j)
				{
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
						i * placeSizeWidth + 150, j * placeSizeHeight);
					g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
				}
			}
			for (int i = 0; i < countPlaces; i++)
			{
				if (parking.getObject(i) != null)
				{
					parking.getObject(i).sePosition(10 + (200 * (i/5)), 25 + (80*(i%5)));
					parking.getObject(i).drawShip(g);
				}
			}			
		}
	}
}
