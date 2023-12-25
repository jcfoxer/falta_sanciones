using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscar_elemntos__en_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ltb1.Items.Add(txt1.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int longitud;
            int índice;
            bool encontrado;
            string elementoDeseado;
            longitud = ltb1.Items.Count;
            elementoDeseado = txt2.Text;
            encontrado = false;
            índice = 0;
            while ((encontrado == false) && (índice < longitud))
            {
                if (Convert.ToString(ltb1.Items[índice]) == elementoDeseado)
                {
                    encontrado = true;
                    MessageBox.Show("Elemento encontrado");
                }
                else
                {
                    índice++;



                }
            }

        }
    }
}