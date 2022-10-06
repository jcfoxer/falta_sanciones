using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balotario3_ejerccio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Declaración de Variables
            
            double unidades   ,icompra = 0, idescuento = 0, ipagar;

            // Entrada de Datos
            unidades = double.Parse(txtunidades.Text);

            // Cálcular el Importe de la Compra
            if (unidades >= 1 && unidades <= 25)
                icompra = 27.7 * unidades;
            if (unidades >= 26 && unidades <= 50)
                icompra = 25.5 * unidades;
            if (unidades >= 51 && unidades <= 75)
                icompra = 23.5 * unidades;
            if (unidades >= 76)
                icompra = 21.5 * unidades;

            // Cálcular el Importe de Descuento
            if (unidades > 50)
                idescuento = 0.15 * icompra;
            if (unidades <= 50)
                idescuento = 0.05 * icompra;

            // Cálcular el importe a pagar
            ipagar = icompra - idescuento;


            // Salida de Resultados

            txtcon.Text = icompra.ToString();
            txtdes.Text = idescuento.ToString();
            txtpaga.Text = ipagar.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //me falat los mocmandos para salir y borrarr




        }
    }
}
