﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_numeros_sinparametor_metodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int resultado = 0;
            sumanumeros metodos = new sumanumeros();
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);

            resultado = metodos.suma(a, b);

            txt3.Text = resultado.ToString();

        }


    }
    }

