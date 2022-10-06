using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_dos_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            double num1, num2,suma;

            num1 = double.Parse(txt1.Text);
            num2 = double.Parse(txt1.Text);

            if (num1 < 0)

                MessageBox.Show("numero uno debe ser mayor a cero");

           else  

                    if (num2<0)

                    MessageBox.Show("numero dos  debe ser mayor a cero");



            suma = num1 + num2;

            MessageBox.Show("la suma es :" + suma);



        }
    }
}
