using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uso_while_adivinar_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Generar un número aleatorio entre 1 y 10
            int numeroAleatorio = new Random().Next(1, 11);

            // Inicializar el bucle
            int intentos = 0;
            while (intentos < 10)
            {
                // Solicitar al usuario que ingrese un número
                MessageBox.Show("Introduce un número entre 1 y 10:");
                int numeroIngresado = int.Parse(txt1.Text);

                // Comparar el número ingresado con el número aleatorio
                if (numeroIngresado == numeroAleatorio)
                {
                    // El usuario acertó
                    MessageBox.Show("¡Felicidades! Has acertado en {0} intentos." + intentos+1);
                    break;
                }
                else
                {
                    // El usuario falló
                    MessageBox.Show("El número que has ingresado es incorrecto.");
                }

                // Incrementar el número de intentos
                intentos++;
            }

            // Si el usuario no acertó en 10 intentos, imprimir un mensaje de derrota
            if (intentos == 10)
            {
                MessageBox.Show("Has perdido. El número correcto era {0}."+ numeroAleatorio);
            }



        }


    }
    }

