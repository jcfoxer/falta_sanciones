using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_registro_ventas
{
    public partial class Form1 : Form
    {

        double precio = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


           // cboproductos.Items.Add("coleccion escolar");
            //cboproductos.Items.Add("coleccion preuniveristaria");
            //cboproductos.Items.Add("coleccion profesional ");

            //cbotipo.Items.Add("contado");
          //  cbotipo.Items.Add("tarjeta");

            lblfecha.Text = DateTime.Today.ToString("d");
            lblprecio.Text = (0).ToString("c");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string producto = cboproductos.Text;

            if (producto.Equals("coleccion escolar")) precio = 250;
            if (producto.Equals("coleccion preuniversitaria")) precio = 150;
            if (producto.Equals("coleccion profesional")) precio = 350;

            lblprecio.Text = precio.ToString("c");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //validando
            if (cboproductos.SelectedIndex == -1)
            
                MessageBox.Show("debe selecionar un producto");

            
            else if (txtcantidad.Text == "") 

            MessageBox.Show("debe ingresar una cantidad");

            else if (cbotipo.SelectedIndex == -1)
            
                MessageBox.Show("debe selecionar un tipo");

            

            else
            {
                //captutra de datos 
                string productos = cboproductos.Text;
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                string tipo = cbotipo.Text;

                //procesar calculos 

                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;

                if (tipo.Equals("contado"))

                    descuento = 0.05 * subtotal;
                else

                    recargo = 0.1 * subtotal;
                double preciofinal = subtotal - descuento + recargo;


                //impresionde resultados 

                ListViewItem fila = new ListViewItem(productos);

                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(preciofinal.ToString());

                lvventa.Items.Add(fila);
                
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
