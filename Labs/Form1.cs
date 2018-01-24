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
    public partial class Form1 : Form
    {
        Parking port;
        additionalForm addiForm;
        Logger logger;
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
            logger = LogManager.GetCurrentClassLogger();

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

        private void TakeBoat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string stage = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        ITransport ship = port.GetShipInParking(Convert.ToInt32(maskedTextBox1.Text) - 1);
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.sePosition(0, 80);
                        ship.drawShip(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                        logger.Info("Корабль забран с места: " + Convert.ToInt32(maskedTextBox1.Text) +
                            ". На уровне: " + port.getCurentLvl);
                    }
                    catch (DockIndexOutOfRangeException ex)
                    {
                        logger.Info(ex.Message);
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        logger.Info(ex.Message);
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            port.lvlUp();
            listBox1.SelectedIndex = port.getCurentLvl;
            logger.Info("Переход на уровень выше. Текущий уровень: " + port.getCurentLvl);
            Draw();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            port.lvlDown();
            listBox1.SelectedIndex = port.getCurentLvl;
            Draw();
            logger.Info("Переход на уровень ниже. Текущий уровень: " + port.getCurentLvl);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            addiForm = new additionalForm();
            logger.Info("Начато создание коробля");
            addiForm.AddEvent(addBoat);
            addiForm.Show();
        }

        private void addBoat(ITransport boat) {
            if (boat != null)
            {
                try
                {
                    int place = port.PutShipInParking(boat);
                    Draw();
                    MessageBox.Show("Ваше место:" + (place + 1));
                    logger.Info("Корабль пришвартован на место: " + (place + 1));
                }
                catch (DockOverflowException ex)
                {
                    logger.Info(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(DockAlreadyHaveException ex)
                {
                    logger.Info(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка повтора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    logger.Info(ex.Message);
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.SaveData(saveFileDialog1.FileName))
                {
                    logger.Info("Доки сохранены в файл: " + saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logger.Info("Неудалось сохранить доки в файл: " + saveFileDialog1.FileName);
                    MessageBox.Show("Не сохранилось", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.LoadData(openFileDialog1.FileName))
                {
                    logger.Info("Загружены доки из файла: " + openFileDialog1.FileName);
                    Draw();
                    MessageBox.Show("Загружено", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logger.Info("Неудалось загрузить доки из файла: " + openFileDialog1.FileName);
                    MessageBox.Show("Ошибка", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Sort();
            Draw();
        }
    }
}
