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
        Color color;
        Color dopColor;
        int maxSpeed;
        int weight;
		int maxCountPass;

		private ITransport trasport;


        public Form1()
        {
            color = Color.Blue;
            dopColor = Color.Gray;
            InitializeComponent();
            maxSpeed = 150;
			weight = 150;
			maxCountPass = 4;
			Weight.Text = "" + weight;
            Speed.Text = "" + maxSpeed;
			Passengers.Text = "" + maxCountPass;
        }
		private bool checkFields()
		{
			if (!int.TryParse(Speed.Text, out maxSpeed))
			{
				return false;
			}
			if (!int.TryParse(Passengers.Text, out maxCountPass))
			{
				return false;
			}
			if (!int.TryParse(Weight.Text, out weight))
			{
				return false;
			}
			return true;
		}







		private void button1_Click(object sender, EventArgs e)
        {

            if (checkFields())
            {
				trasport = new MotorShip(maxSpeed,maxCountPass,weight,color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
				trasport.drawShip(gr);
                pictureBox1.Image = bmp;
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
				trasport = new UltaMegaBuffSuperMotorShip(maxSpeed, maxCountPass, weight, color,
					true,true, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
				trasport.drawShip(gr);
				pictureBox1.Image = bmp;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trasport != null) {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
				trasport.moveShip(gr);
				pictureBox1.Image = bmp;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button4.BackColor = color;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button5.BackColor = dopColor;
            }
        }
    }
}
