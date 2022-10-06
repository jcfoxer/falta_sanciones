using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balotario03_ejerccio3
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
            double numero;
            String obsequio = "Ninguno";
            // Entrada de datos
            numero = double.Parse(txtnumero.Text);
            // Determina el obsequio
            if (numero >= 1 && numero <= 20)
                obsequio = "Un lapicero";
            if (numero >= 21 && numero <= 40)
                obsequio = "Un cuaderno de 100 hojas";
            if (numero >= 41 && numero <= 60)
                obsequio = "Una caja de 12 plumones";
            if (numero >= 61 && numero <= 80)
                obsequio = "Un cuaderno espiral";
            if (numero >= 81 && numero <= 99)
                obsequio = "Una agenda";
            if (numero == 100)
                obsequio = "Una mochila";



            // Salida de resultados

            txtob.Text = obsequio.ToString();





        }
    }
}
