﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal_Jogo
{
    public partial class Form1 : Form
    {
        public static string nome;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMega_Click(object sender, EventArgs e)
        {
            nome = txbNome.Text;
            MegaSenaForm mega = new MegaSenaForm();
            mega.Show();
        }

        private void btnPalavras_Click(object sender, EventArgs e)
        {
            nome = txbNome.Text;
            PalavrasForm palavraForm = new PalavrasForm();
            palavraForm.Show();
        }
    }
}
