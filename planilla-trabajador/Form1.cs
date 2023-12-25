using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planilla_trabajador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int  sueldo=0, diastra=0, sueltotal=0;

            sueldo = int.Parse(textBox1.Text);
          diastra = int.Parse(textBox2.Text);

            if (radioButton1.Checked == true)
            {
                sueltotal = sueltotal + 100;

            }
            if (radioButton2.Checked == true)
            {
                sueltotal = sueltotal + 200;
            }

            if (this.checkBox1.Checked == true)
            {
                sueltotal = sueltotal +45;

            }

            if (this.checkBox2.Checked == true)
            {
                sueltotal = sueltotal *10;
            }


            sueltotal = sueldo * diastra;

            textBox4.Text = sueltotal.ToString();


        }
    }
}
