using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Declaración de variables

            double impcom, impdes, imppag, precio, cantidad, lapiceros;
            // Entrada de datos
            cantidad = double.Parse(txtcantidad.Text);
            precio = Double.Parse(txtprecio.Text);
            // Calcula el importe de la compra
            impcom = cantidad * precio;
            // Calcula el importe del descuento
            if (cantidad >= 10)
                impdes = 0.15 * impcom;
            else
                impdes = 0.11 * impcom;
            // Calcula el importe a pagar
            imppag = impcom - impdes;
            // Calcula los lapiceros de obsequio
            if (imppag >= 200)
                lapiceros = 2 * cantidad;
            else
                lapiceros = 0;
            // Salida de resultados

            txtco.Text = impcom.ToString();
            txtdes.Text = impdes.ToString();
            txtpa.Text = imppag.ToString();
            txtla.Text = lapiceros.ToString();

        }



        private void button2_Click(object sender, EventArgs e)

        {


            // Procesa la pulsación del botón Borrar

           // txtcantidad.setText("");
            //txtprecio.setText("");
           // txts.setText("");
           // txtcantidad.requestFocus();
        }
    }


}



    
