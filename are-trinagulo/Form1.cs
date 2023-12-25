using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace are_trinagulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            int area;
            int longitud;
            int ancho;
            longitud = 20;
            ancho = 10;
            area = longitud * ancho;
            MessageBox.Show("El área es: " +area);




        }
    }
}
