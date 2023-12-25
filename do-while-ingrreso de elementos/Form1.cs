using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace do_while_ingrreso_de_elementos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Declaramos una variable para almacenar el número de alumnos
            int numeroAlumnos = 0;

            // Declaramos una variable para almacenar los datos de cada alumno
            datos_alumnos alumno;

            // Inicializamos el bucle
            do
            {
                // Solicitamos los datos del alumno
                alumno = new datos_alumnos();
                alumno.IngresarDatos(this);

                // Incrementamos el número de alumnos
                numeroAlumnos++;

                // Preguntamos si se desea ingresar otro alumno
                MessageBox.Show("¿Desea ingresar otro alumno? (S/N)", "Matrícula de alumnos", MessageBoxButtons.YesNo);

            } while (DialogResult.Yes == MessageBox.Show("¿Desea ingresar otro alumno? (S/N)", "Matrícula de alumnos", MessageBoxButtons.YesNo));

            // Imprimimos el número de alumnos matriculados
            textBox3.Text = "Se han matriculado " + numeroAlumnos + " alumnos";

             class Alumno
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public string correo { get; set; }

            public void IngresarDatos()
            {
                // Solicitamos el nombre del alumno
                nombre = TextBox1.text();
               

                // Solicitamos la edad del alumno
                form.TextBox2.Text = "";
                form.TextBox2.Focus();
                form.WaitForInputIdle();

                // Solicitamos el correo electrónico del alumno
                form.TextBox3.Text = "";
                form.TextBox3.Focus();
                form.WaitForInputIdle();

                // Guardamos los datos del alumno
                nombre = form.TextBox1.Text;
                edad = int.Parse(form.TextBox2.Text);
                correo = form.TextBox3.Text;





            }
        }
    }
}