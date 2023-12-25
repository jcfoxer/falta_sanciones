using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_adivinar_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declarar variables

            int numero, numero1, contador;

            numero1 = 5;

            contador = 0;

            numero = int.Parse(textBox1.Text);

            if (numero == numero1)
            {

                MessageBox.Show("has adivinado el numero que suertudo eres ");
            }


            else
                while ((numero != numero1) && (contador <= 1))
                {

                    MessageBox.Show("numero incorrecto");
                    MessageBox.Show("ingresa otro numero del 1 al 10");

                    if (numero == numero1) { MessageBox.Show("adivinaste el numero "); }

                    return;
                }
                

        }
    }
}
