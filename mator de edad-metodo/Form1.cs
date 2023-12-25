using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mator_de_edad_metodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int resultado ;
            mayor_edad metodos = new mayor_edad();

            int edad = int.Parse(textBox1.Text);

            resultado = metodos.mayor(edad);


            MessageBox.Show(+resultado + "");


        }
    }
}
