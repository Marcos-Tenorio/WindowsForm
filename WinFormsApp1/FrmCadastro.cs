﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            int numero = int.Parse(txtNumero.Text);

            numero += 100;

            MessageBox.Show("Olá " + nome + ", o valor do numero somado a 100 é de: " + numero);


        }
    }
}
