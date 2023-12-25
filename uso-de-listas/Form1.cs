using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uso_de_listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int suma = 0;
            foreach (string s in numeros.Items)
            {
                int número = Convert.ToInt32(s);
                suma = suma + número;
            }
            txt1.Text = Convert.ToString(suma);




        }

        private void button1_Click(object sender, EventArgs e)
        {

            numeros.Items.Add(txt2.Text);



        }

        private void button3_Click(object sender, EventArgs e)
        {

            int mayor;
            mayor = Convert.ToInt32(Convert.ToString(numeros.Items[0]));
            foreach (string s in numeros.Items)

            {
                int número = Convert.ToInt32(s);
                if (número > mayor)
                {
                    mayor = número;
                }
            }
            txt3.Text = Convert.ToString(mayor);

        }
    }
}
