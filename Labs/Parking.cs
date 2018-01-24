using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Parking
	{
        List<ClassArray<ITransport>> parkingStages;
		int countPlaces = 20;
		int placeSizeWidth = 210;
		int placeSizeHeight = 80;
        int curentLvl;

        public int getCurentLvl { get { return curentLvl; } }

        public void lvlUp()
        {
            if (curentLvl + 1 < parkingStages.Count)
            {
                curentLvl++;
            }
        }

        public void lvlDown()
        {
            if (curentLvl > 0)
            {
                curentLvl--;
            }
        }

        public Parking(int lvls)
		{
            parkingStages = new List<ClassArray<ITransport>>();
            for(int i = 0; i < lvls; i++)
            {
                parkingStages.Add(new ClassArray<ITransport>(countPlaces, null));
            }

        }

		public int PutShipInParking(ITransport ship)
		{
            return parkingStages[curentLvl] + ship;
		}

        public ITransport GetShipInParking(int ticket)
        {
            return parkingStages[curentLvl] - ticket;
		}


        public void Draw(Graphics g)
        {
            DrawMaking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var car = parkingStages[curentLvl][i];
                if (car != null)
                {
                    car.sePosition(10 + (200 * (i / 5)), 25 + (80 * (i % 5)));
                    car.drawShip(g);
                }
            }
        }

        private void DrawMaking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (curentLvl + 1), new Font("Arial", 30), new SolidBrush(Color.Black),
                (countPlaces / 5) * placeSizeWidth + 50, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 420);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 150, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
                            new SolidBrush(Color.Black), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }

        public bool SaveData(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using(FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
                        parkingStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach(var lvl in parkingStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Lvl" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for(int i = 0;i <countPlaces; i++)
                        {
                            var ship = lvl[i];
                            if (ship != null)
                            {
                                if(ship.GetType().Name == "MotorShip")
                                {
                                    info = new UTF8Encoding(true).GetBytes("MotorShip:");
                                    fs.Write(info, 0, info.Length);
                                }
                                else if (ship.GetType().Name == "UltaMegaBuffSuperMotorShip")
                                {
                                    info = new UTF8Encoding(true).GetBytes("UltaMegaBuffSuperMotorShip:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(ship.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }
            using(FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if(parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<ClassArray<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for(int i = 0; i < strs.Length; i++)
                {
                    if(strs[i] == "Lvl")
                    {
                        counter++;
                        parkingStages.Add(new ClassArray<ITransport>(countPlaces, null));
                    }
                    else if(strs[i].Split(':')[0] == "MotorShip")
                    {
                        ITransport ship = new MotorShip(strs[i].Split(':')[1]);
                        if((parkingStages[counter] + ship) == -1)
                        {
                            return false;
                        }
                    }
                    else if(strs[i].Split(':')[0] == "UltaMegaBuffSuperMotorShip")
                    {
                        ITransport ship = new UltaMegaBuffSuperMotorShip(strs[i].Split(':')[1]);
                        if ((parkingStages[counter] + ship) == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
