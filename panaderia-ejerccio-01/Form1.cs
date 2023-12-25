using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panaderia_ejerccio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           //  Declaración de variables
double impcom, impdes=0, imppag, precio, cantidad;
            // Entrada de datos

            precio = Double.Parse(textBox1.Text);
            cantidad = double.Parse(textBox2.Text);
            
            // Calcula el importe de la compra
            impcom = cantidad * precio;
            // Calcula el importe del descuento
            if (cantidad >= 50 && cantidad<=150)
                impdes = 0.06 * impcom;
            if (cantidad >=151 && cantidad <= 250)
                impdes = 0.10 * impcom;
            if(cantidad>=251)

                impdes = 0.15 * impcom;


            // Calcula el importe a pagar
            imppag = impcom - impdes;
            


            // Salida de resultados


            textBox3.Text = impcom.ToString();
            textBox4.Text = impdes.ToString();
            textBox5.Text = imppag.ToString();
            








        }
    }
}
