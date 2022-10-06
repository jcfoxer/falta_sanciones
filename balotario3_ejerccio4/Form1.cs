using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balotario3_ejerccio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Declaración de variables
            
            double impcom, impdes, imppag,turno=0, cantidad=0,caramelos  ;


            // Entrada de datos

            cantidad = double.Parse(txtcantidad.Text);
            string selectedItem = cboturno.Items[cboturno.SelectedIndex].ToString();


           
            // Calcula el importe de la compra
            if (turno == 0)
                impcom = 37.5 * cantidad;
            else
                impcom = 45.0 * cantidad;
            // Calcula el importe del descuento
            if (cantidad >= 15)
                impdes = 0.08 * impcom;
            else
                impdes = 0.05 * impcom;
            // Calcula el importe a pagar
            imppag = impcom - impdes;
            // Calcula los caramelos de obsequio
            if (imppag > 200)
                caramelos = 2 * cantidad;
            else
                caramelos = 0;

            // Salida de resultados

            txtco.Text = impcom.ToString();
            txtdes.Text = impdes.ToString();
            txtpa.Text = imppag.ToString();
            txtca.Text = caramelos.ToString();



        }
    }
}
