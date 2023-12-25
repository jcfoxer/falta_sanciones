using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo_asteristocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a=0 ;
            for(int y = 1; y <= a; y++)
            {
                for (int x = 1; x <= a - y; x++)
                {
                    MessageBox.Show("");
                }

                for(int x = 1; x <= y; x++)
                {
                    MessageBox.Show("*");
                }

                for(int x = 1; x <= y - 1; x++)
                {
                    MessageBox.Show("*");
                }



            }


        }
    }
}
