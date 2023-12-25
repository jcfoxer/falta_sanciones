using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastos_diarios
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

            double[] vgastos;
            double gasto, totalgasto, diamayor, gastomayor;
            int cantdias;
            //iniciar variables

            totalgasto = 0;
            diamayor = 1;
            gastomayor = 0;
            //empezamos aller los gastos

            cantdias = int.Parse(textBox1.Text);
            vgastos = new double[cantdias];
            for (int dia = 1; dia <= cantdias; dia++)
            {

                gasto = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("ingrese el gasto del dia"+dia, "gastos"));
                vgastos[dia - 1] = gasto;


            }
             
            for (int i=0;i<cantdias;i++)
            {

                //evaluamos  el gasto mayor
                if (vgastos[i] > gastomayor)

                {
                    gastomayor = vgastos[i];
                    diamayor = i + 1;

                }

                //calculamos el total de gastos 
                totalgasto = totalgasto + vgastos[i];
                //mostrar los gastos en el combobox 

                comboBox1.Items.Add("dia" + (i + 1) + "total:" + vgastos[i]);


            }

            //mostar la informacion 
            textBox2.Text = gastomayor.ToString();
            textBox3.Text = diamayor.ToString();
            textBox4.Text = totalgasto.ToString();


        }
    }
}
