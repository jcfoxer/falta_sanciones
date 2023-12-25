using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones_artiemticas_conlistbox
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double suma = 0;

            double promedio = 0;
            foreach (string s in numeros.Items)
            {

                int numeros = Convert.ToInt32(s);
                suma = suma + numeros;

                promedio = suma / 2;

            }


            textBox2.Text = Convert.ToString(promedio);



        }

        private void button3_Click(object sender, EventArgs e)
        {


            //operaciones para encontrar los numeros menores a 10
           
           
             int numero10=0;
            //menor10 = Convert.ToInt32(Convert.ToString(numeros.Items[0]));

            foreach (int numero1 in numeros.Items)

              

            {
              

              
            

                if (numero1<=10  )
                {
                    numero10++;  
                
                }

                textBox3.Text = Convert.ToString(numero1);

            }
        }

        //operacion para encontrar los numeros menores a 10 y mayores a 15



        //operacion para encontrar los numeros mayores a 15










        private void button1_Click(object sender, EventArgs e)
        {
            
            numeros.Items.Add(int.Parse(textBox1.Text));
           
            

        }


    }

}