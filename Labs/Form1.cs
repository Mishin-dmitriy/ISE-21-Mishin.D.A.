using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
	public partial class Form1 : Form
	{
        Knife knife;
        Meat meat;
        MeatGrinder meatGrinder;
        Oil oil;
        Pan pan;
        Plate plate;
        Spice spice;
        Crane crane;
        Cutlets cutlets;
        Egg egg;
        ForceMeat forceMeat;
       
		public Form1()
		{
			InitializeComponent();
            meatGrinder = new MeatGrinder();
            knife = new Knife();
            plate = new Plate();
            crane = new Crane();
            oil = new Oil();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

        private void button9_Click(object sender, EventArgs e)
        {
            if(meat == null)
            {
                meat = new Meat();
                MessageBox.Show("Мясо взято", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас уже есть мясо", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (egg == null)
            {
                egg = new Egg();
                MessageBox.Show("Яйца взяты", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас уже есть яйца", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (spice == null)
            {
                spice = new Spice();
                MessageBox.Show("Cпеции взяты", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас уже есть специи", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (craneOnOff.Checked)
            {
                if (meat != null)
                {
                    crane.cleanMeat(meat);
                    MessageBox.Show("Мясо помыто", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("Вы не взяли мясо", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не включили кран", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (craneOnOff.Checked)
            {
                if (egg != null)
                {
                    crane.cleanEgg(egg);
                    MessageBox.Show("Яйца помыты", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не взяли яйца", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не включили кран", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (meat != null)
            {
                if (meat.isClean)
                {
                    knife.cutMeat(meat);
                    MessageBox.Show("Мясо нарезано", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сначала помойте мясо", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не взяли мясо", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (egg != null)
            {
                if (egg.isClean)
                {
                    knife.brokeEgg(egg);
                    MessageBox.Show("Яйца разбиты", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сначала помойте яйца", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не взяли яйца", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (grinderOnOff.Checked)
            {
                if (meat != null)
                {
                    if (meat.isClean)
                    {
                        if (meat.isCut)
                        {
                            meatGrinder.meat = meat;
                            MessageBox.Show("Мясо добавленно", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Вам нужно нарезеать мясо", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вам нужно помыть и нарезать мясо", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не взяли мясо", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не включили мясорубку", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (grinderOnOff.Checked)
            {
                if (egg != null)
                {
                    if (egg.isClean)
                    {
                        if (egg.isBroken)
                        {
                            meatGrinder.egg = egg;
                            MessageBox.Show("Яйца добавленны", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Вам нужно разбить яйца", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вам нужно помыть и разбить яйца", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не взяли яйца", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не включили мясорубку", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (grinderOnOff.Checked)
            {
                if (spice != null)
                {
                    meatGrinder.spice = spice;
                    MessageBox.Show("Специи добавлены", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не взяли специи", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не включили мясорубку", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            meatGrinder.state = grinderOnOff.Checked;
            forceMeat = meatGrinder.getForceMeat();
            if (forceMeat != null)
            {
                MessageBox.Show("Фарш приготовлен", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нехватает ингредиентов или мясорубка выключена", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pan == null)
            {
                pan = new Pan();
                MessageBox.Show("Сковорода взята", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас уже есть сковорода", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(pan != null)
            {
                if(oil != null)
                {
                    pan.oil = oil;
                    MessageBox.Show("Масло добавлено", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не взяли масло", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Вы не взяли сковороду", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(pan != null)
            {
                cutlets = pan.cutlets;
                if(cutlets != null)
                {
                    MessageBox.Show("Котлеты приготовленны", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {
                    MessageBox.Show("Котлеты ещё не готовы", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не взяли сковороду", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (pan != null)
            {
                plate.pan = pan;
                MessageBox.Show("Сковорода поставлена", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы не взяли сковороду", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (plate.pan != null)
            {
                if (plateOnOff.Checked)
                {
                    for(int i = 0; i < 10; i++)
                    {
                        plate.cookIng();
                    }
                    MessageBox.Show("Сковорода нагрета на 10 градусов", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Плита выключена", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не взяли сковороду", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (pan != null)
            {
                if (forceMeat != null)
                {
                    pan.forceMeat = forceMeat;
                    MessageBox.Show("Фарш добавлен", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не приготовили фарш", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не взяли сковороду", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
