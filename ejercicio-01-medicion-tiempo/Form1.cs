using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_01_medicion_tiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarar variables 

            int numveces1=0,numveces2=0,numveces3=0;
            double min1=0, min2, min3, min4, min5, min6, min7, min8, min9, min10,promedio;

            //capturar datos

            min1 = double.Parse(textBox1.Text);
            min2 = double.Parse(textBox2.Text);
            min3 = double.Parse(textBox3.Text);
            min4 = double.Parse(textBox4.Text);
            min5 = double.Parse(textBox5.Text);
            min6 = double.Parse(textBox6.Text);
            min7 = double.Parse(textBox7.Text);
            min8 = double.Parse(textBox8.Text);
            min9 = double.Parse(textBox9.Text);
            min10 = double.Parse(textBox10.Text);

            //operaciones 


            promedio = ((min1 + min2 + min3 + min4 + min5 + min6 + min7 + min8 + min9 + min10) / 10);

            if (numveces1>10)





            //salida de datos



            textBox14.Text = promedio.ToString();
            textBox11.Text = numveces1.ToString();
            textBox12.Text = numveces2.ToString();
            textBox13.Text = numveces3.ToString();

        }
    }
}
