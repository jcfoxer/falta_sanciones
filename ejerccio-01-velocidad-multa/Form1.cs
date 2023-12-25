using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerccio_01_velocidad_multa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            int velocidad =0,multa=0;

            velocidad = int.Parse(textBox1.Text);




            if (velocidad <= 60)
                label3.Text = "velocidad permitida";

            if (velocidad>=60 && velocidad<=65 )

                label3.Text = "peligro en el limite de velocidad";
            if (velocidad >= 60)


                label3.Text = "HA SOBREPASADO LOS LIMITES DE VELOCIDAD  PERMITIDO";


            if (velocidad >= 66 && velocidad <= 75)

                multa = 300;

            if (velocidad >= 76 && velocidad <= 86)

                multa = 750;

            if (velocidad >= 87 && velocidad <=100)

                multa = 1500;

            if (velocidad >= 100 )

                multa = 3750;


            textBox2.Text = multa.ToString();



        }
    }
}
