using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace else_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declarar variables 

            int a;

            a = int.Parse(textBox1.Text);

            if (a==1) //  si a es igual a 1 

            { MessageBox.Show("a vale " + a + "");  }
            else if (a==2  )// si a es igual a 1
            { MessageBox.Show("a vale " + a + "");   }

            else { MessageBox.Show("a no vale ni uno ni dos "); }

        }
    }
}
