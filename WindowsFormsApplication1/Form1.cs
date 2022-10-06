using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //declarar variables
            int V, T;
            float D;
            //leer datos
            V = int.Parse(txtVelocidad.Text);
            T = int.Parse(txtTiempo.Text);
            //procesos
            D = V * T;
            //escribir resultados
            lblres.Text = D.ToString();






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
