using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_indicar_numero_positivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num=0;



            do
            {
                num = int.Parse(textBox1.Text);
            } while (num < 0);

            MessageBox.Show("el numero ingresado es negativo ");
            
            {
               
                MessageBox.Show("el numero ingresado es: "+num+" es positivo ");

            }

            return;

        }
    }
}
