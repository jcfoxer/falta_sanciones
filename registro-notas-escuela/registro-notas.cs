using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_notas_escuela
{
    public partial class registro_notas : Form
    {
        public registro_notas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string es, cur, asig;

            double p1, p2, p3, pp, exa1, exa, pq;
            es = txt1.Text;
            cur= cbo1.Text;
            asig= cbo2.Text;
            p1 = double.Parse(txt2.Text);
            p2= double.Parse(txt3.Text);
            p3= double.Parse(txt4.Text);
            exa= double.Parse(txt5.Text);
            pp = ((p1 + p2 + p3) / 3)*0.80;
            exa1 = exa * 0.2;
            pq = pp + exa1;

            dataGridView1.Rows.Add(es, cur, asig, p1, p2, p3, pp, exa, exa1, pq);
        }

        private void registro_notas_Load(object sender, EventArgs e)
        {
            cbo1.Items.Add("segudno a");
            cbo1.Items.Add("segudno b");
            cbo1.Items.Add("segudno c");
            cbo1.Items.Add("segudno d");

            cbo2.Items.Add("matematicas");
            cbo2.Items.Add("sistemas");
            cbo2.Items.Add("programacion");
            cbo2.Items.Add("ingles");


        }
    }
}
