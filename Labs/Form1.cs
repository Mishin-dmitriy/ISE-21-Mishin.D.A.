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
        Parking port;

        public Form1()
        {
            InitializeComponent();
            port = new Parking(4);
            for(int i=1; i<5; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = port.getCurentLvl;
            Draw();

        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics grf = Graphics.FromImage(bmp);
                port.Draw(grf);
                pictureBox1.Image = bmp;
            }
        }





        private void putBoatInDock_Click(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();
            if (colDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var boat = new MotorShip(100, 4, 1000, colDialog.Color);
                int place = port.PutShipInParking(boat);
                Draw();
                MessageBox.Show("Судно в доке с номером:" + (place+1));

            }
        }



        private void TakeBoat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string stage = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    var boat = port.GetShipInParking(Convert.ToInt32(maskedTextBox1.Text)-1);
                    if (boat != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        boat.sePosition(0, 80);
                        boat.drawShip(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Тут ничего нет");
                    }
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            port.lvlUp();
            listBox1.SelectedIndex = port.getCurentLvl;
            Draw();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            port.lvlDown();
            listBox1.SelectedIndex = port.getCurentLvl;
            Draw();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();
            if (colDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var sail_boat = new UltaMegaBuffSuperMotorShip(100, 4, 1000, colDialog.Color, true, true, dialogDop.Color);
                    int place = port.PutShipInParking(sail_boat);
                    Draw();
                    MessageBox.Show("Парусник в доке с номером:" + (place + 1));
                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var car = new MotorShip(100, 4, 1000, dialog.Color);
                int place = port.PutShipInParking(car);
                Draw();
                MessageBox.Show("Вашеместо: " + (place + 1));
            }
        }
    }
}
