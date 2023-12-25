using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_simpe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {


            string login, password;
            login = txt1.Text.TrimEnd();
            password = txt2.Text.TrimEnd();
            if (login == "juan" && password == "cotrina") 
            {

                MessageBox.Show("bienvenido al sistema");
            }

            else {
                MessageBox.Show("acceso denegado");

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txt1.Text="";
            txt2.Text = "";



        }
    }
}
