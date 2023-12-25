using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_triangulo_metodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double resultado = 0;
            operacion_area metodos = new operacion_area();



            double bas =double.Parse(textBox1.Text);
            double altura = double.Parse(textBox2.Text);

            resultado = metodos.area(bas, altura);

            //textBox3.Text = resultado.ToString();//este utliza el texbox field 


            MessageBox.Show(+resultado +""); //este utliza una ventana emergente 


        }
    }
}
