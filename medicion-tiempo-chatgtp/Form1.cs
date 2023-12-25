using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicion_tiempo_chatgtp
{
    public partial class Form1 : Form
    { private List<int> numeros = new List<int>();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (int.TryParse(txtnumero.Text, out  numero))
            {
                numeros.Add(numero);
                lstnumeros.Items.Add(numero);
                txtnumero.Clear();
            }

            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int menorQue10 = numeros.Count(num => num < 10);
            int entre10Y15 = numeros.Count(num => num >= 10 && num <= 15);
            int mayorQue15 = numeros.Count(num => num > 15);

            double promedio = numeros.Any() ? numeros.Average() : 0;

            label2.Text = $"Menor que 10: {menorQue10}";
            label3.Text = $"Entre 10 y 15: {entre10Y15}";
            label4.Text = $"Mayor que 15: {mayorQue15}";
            label5.Text = $"Promedio: {promedio:F2}";
        }




    }
    }
    

