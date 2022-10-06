using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balotario03_ejercicio05
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
            double impven, suelbas, comi, bonif, suelbru, desc, suelnet,hijos;
            

            // Entrada de datos
            impven = double.Parse(txtimporte.Text);
            hijos = double.Parse(txthijos.Text);

            // Asignación del sueldo básico
            suelbas = 600;

            // Calcula la comisión
            if (impven > 15000)
                comi = 0.07 * impven;
            else
                comi = 0.05 * impven;

            // Calcula la bonificación
            if (hijos < 5)
                bonif = 25 * hijos;
            else
                bonif = 22 * hijos;

            // Calcula el sueldo bruto
            suelbru = suelbas + comi + bonif;

            // Calcula el descuento
            if (suelbru > 3500)
                desc = 0.15 * suelbru;
            else
                desc = 0.11 * suelbru;

            // Calculo el sueldo neto
            suelnet = suelbru - desc;



            //salida de datos

            txtsu.Text = suelbas.ToString();
            txtco.Text = comi.ToString();
            txtbo.Text = bonif.ToString();
            txtsubru.Text = suelbru.ToString();
            txtdes.Text = desc.ToString();
            txtsune.Text = suelnet.ToString();
            


        }
    }
}
