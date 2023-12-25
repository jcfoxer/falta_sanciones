using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercio_02_cuota_univerisdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declarar varibales 

            double cuota=0, imporpagar=0, descuento=0;


            //capturar datos


            cuota = double.Parse(textBox1.Text);


            if (checkBox1.Checked == true &&radioButton3.Checked==true)
            {

                descuento = cuota * 0.50;

            }
            if (checkBox1.Checked == true && radioButton4.Checked == true)
            {

                descuento = cuota * 0.40;

            }
            if (checkBox1.Checked == true && radioButton5.Checked == true)
            {

                descuento = cuota * 0.30;

            }
            if (checkBox2.Checked == true && radioButton3.Checked == true)
            {

                descuento = cuota * 0.25;

            }
            if (checkBox2.Checked == true && radioButton4.Checked == true)
            {

                descuento = cuota * 0.20;

            }
            if (checkBox2.Checked == true && radioButton5.Checked == true)
            {

                descuento = cuota * 0.15;

            }


            imporpagar = cuota - descuento;

            textBox2.Text = descuento.ToString();
            textBox3.Text = imporpagar.ToString();





        }
    }
}




