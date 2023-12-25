using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uso_swicth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("lunes descuento 1%");
            comboBox1.Items.Add("martes descuento 2%");
            comboBox1.Items.Add("miercoles decuento 3% ");
            comboBox1.Items.Add("jueves descuento de 4%");
            comboBox1.Items.Add("viernes descuento de 5%");






        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declaro variables
           int totalcompra=0, totalpagar=0;
            int desc1, desc2, desc3, desc4, desc5;

            desc1 = 100 / 10;
            desc2 = 100 / 20;
            desc3 = 100 / 30;
            desc4 = 100 / 40;
            desc5 = 100 / 50;

            totalcompra = int.Parse(textBox1.Text);

           

            //operaiones 

            switch (comboBox1.SelectedIndex)
            {

                case 0:

                    totalpagar = totalcompra - desc1;
                    textBox2.Text = totalpagar.ToString();

                    break;
                case 1:

                    totalpagar = totalcompra - desc2;
                    textBox2.Text = totalpagar.ToString();


                    break;
                case 2:


                    totalpagar = totalcompra - desc3;
                    textBox2.Text = totalpagar.ToString();
                    break;
                case 3:

                    totalpagar = totalcompra - desc4;
                    textBox2.Text = totalpagar.ToString();


                    break;
                case 4:

                    totalpagar = totalcompra - desc5;
                    textBox2.Text = totalpagar.ToString();

                    break;

                    //  default solo se pone cuando se introduce un valor errdadao  

            


            }

            
            


           

        }
    }
}
