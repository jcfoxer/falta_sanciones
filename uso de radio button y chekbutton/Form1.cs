using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uso_de_radio_button_y_chekbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int total = 0;

            if (rbt1.Checked == true)
            {
                total = total + 50;
            }

            if (rbt2.Checked == true)
            {
                total = total + 100;
            }

            if (rbt3.Checked == true)
            {
                total = total + 150;
            }

            if (this.chk1.Checked == true)
            {
                total = total + 5;
            }
            if (this.chk2.Checked == true)
            {
                total = total + 15;
            }

            if (this.chk3.Checked == true)
            {
                total = total + 20;
            }

            MessageBox.Show("el total de gastos d envio es :" + total.ToString("c2"));

                
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
