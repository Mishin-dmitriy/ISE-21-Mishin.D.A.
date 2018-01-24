using NLog;
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
    public partial class additionalForm : Form
    {
        ITransport boat = null;
        public ITransport getBoat { get { return boat; } }
        private event myDel eventAddBoat;
        private Logger logger;
        public void AddEvent(myDel ev)
        {
            if (eventAddBoat == null)
                eventAddBoat = new myDel(ev);
            else
                eventAddBoat += ev;
        }

        public additionalForm()
        {
            InitializeComponent();
            redCol.MouseDown += colorPanel_MouseDown;
            greenCol.MouseDown += colorPanel_MouseDown;
            pinkCol.MouseDown += colorPanel_MouseDown;
            blueCol.MouseDown += colorPanel_MouseDown;
            whiteCol.MouseDown += colorPanel_MouseDown;
            brownCol.MouseDown += colorPanel_MouseDown;
            purpleCol.MouseDown += colorPanel_MouseDown;
            greyCol.MouseDown += colorPanel_MouseDown;
            logger = LogManager.GetCurrentClassLogger();
            CancelBtn.Click += (object sender, EventArgs e) => 
            {
                logger.Info("Пользователь отменил добавление корабля");
                Close();
            };
        }

        private void Boatlabel_MouseDown(object sender, MouseEventArgs e)
        {
            Boatlabel.DoDragDrop(Boatlabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void SetBoatpanel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Ship":
                    logger.Info("Пользователь начал создание Ship");
                    boat = new MotorShip(8, 5, 10, Color.Brown);
                    break;
                case "UltaMotorShip":
                    logger.Info("Пользователь начал создание UltaMotorShip");
                    boat = new UltaMegaBuffSuperMotorShip(10, 20, 30, Color.Brown, true,true, Color.LightPink);
                    break;
            }
            DrawBoat(); 
        }

        private void SetBoatpanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.sePosition(5, 30);
                boat.drawShip(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void mainColLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainColLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                logger.Info("Установлен базовый цвет: " + ((Color)e.Data.GetData(typeof(Color))).Name);
                boat.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }

        private void colorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void addColLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void addColLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                if(boat is UltaMegaBuffSuperMotorShip)
                {
                    logger.Info("Установлен базовый цвет: " + ((Color)e.Data.GetData(typeof(Color))).Name);
                    (boat as UltaMegaBuffSuperMotorShip).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBoat();
                }

                
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (eventAddBoat != null)
                logger.Info("Пользователь закончил создание коробля");
                eventAddBoat(boat);
            Close();
        }

        private void Shiplabel_MouseDown(object sender, MouseEventArgs e)
        {
            Shiplabel.DoDragDrop(Shiplabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
