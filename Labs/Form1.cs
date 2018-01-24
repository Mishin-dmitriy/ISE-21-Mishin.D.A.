using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
	public partial class Form1 : Form
	{
		Parking parking;

		public Form1()
		{
			InitializeComponent();
			parking = new Parking();
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
			pictureBoxParking.Image = bmp;
		}

		private void buttonSetCar_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var car = new MotorShip(100, 4, 1000, dialog.Color);
				int place = parking.PutShipInParking(car);
				Draw();
				MessageBox.Show("Вашеместо: " + (place + 1));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (maskedTextBox1.Text != "")
			{
				ITransport car = parking.GetShipInParking(((Convert.ToInt32(maskedTextBox1.Text)) - 1));

				Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
				Graphics gr = Graphics.FromImage(bmp);
				car.sePosition(0, 100);
				car.drawShip(gr);
				pictureBoxTakeCar.Image = bmp;
				Draw();
			}
		}

        private void buttonSetSportCar_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var car = new UltaMegaBuffSuperMotorShip(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
                    int place = parking.PutShipInParking(car);
                    Draw();
                    MessageBox.Show("Вашеместо: " + (place + 1));
                }
            }
        }
    }
}
