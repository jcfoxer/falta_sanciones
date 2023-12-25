using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_nota_de_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declaracion de variables 
            int nota1, nota2 ,promedio,i=0;

            nota1 =int.Parse( textBox1.Text);
            nota2 = int.Parse(textBox2.Text);

            promedio = ((nota1 + nota2) / 2);




            while (promedio<=20)

            {

                if (promedio <= 13)
                    MessageBox.Show("su pomedio es " + promedio + " usted desaprobo el curso ");
                else MessageBox.Show("su promedio es " + promedio + " usted aprobo el curso ");


                return;
            }

           

          


        }
    }
}
