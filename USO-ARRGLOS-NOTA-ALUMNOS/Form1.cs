using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USO_ARRGLOS_NOTA_ALUMNOS
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
            int[]notas = new int[5];
            //especificar notas 
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma =0;
            double promedio;

            //proceso 
            cbonotas.Items.Clear();
            //recorrer nuestra vector 

            for (int i=0;i<=4;i++) { //mostrar las notas en el combobox 

                cbonotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;
            //salida de la informacion 
            txtpromedio.Text = Convert.ToString(promedio);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtpromedio.Clear();
            cbonotas.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
