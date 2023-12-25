using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones_basicas_con_parametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbocal.Text == "")
            {
                MessageBox.Show("selecciones un calcule");

            }
            else if (cbocal.Text == "suma")
            {
                int resultado = 0;
                clase_operaciones metodos = new clase_operaciones();
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                resultado = metodos.suma(a, b);
                textBox3.Text = resultado.ToString();

            }

            else
            {
                int resultado1 = 0;
                clase_operaciones metodos = new clase_operaciones();
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                resultado1 = metodos.resta(a, b);
                textBox3.Text = resultado1.ToString();

            }  
            

            else {
                    int resultado2 = 0;
                    clase_operaciones metodos = new clase_operaciones();
                    int a = int.Parse(textBox1.Text);
                    int b = int.Parse(textBox2.Text);
                    resultado2 = metodos.producto(a, b);
                    textBox3.Text = resultado2.ToString();



                }











            }


        }

    }


