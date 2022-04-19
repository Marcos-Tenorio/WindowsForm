using System;
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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            textResultado.Text = "Olá Marcos." + "Voce é de " + comboBoxSelecione.Text + ".";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.txtRuntime.Text = textResultado.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxSelecione.DataSource = Estado.Lista();
            comboBoxSelecione.Text = "[Selecione]";

            var data = from X in Estado.Lista()
                       orderby X.Name
                       select new
                       {
                           Id = X.Id,
                           Name = X.Name
                       };

            dataGridView.DataSource = data.ToList();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("dd/MM/yyyy HH: mm: ss");
        }

        private void novoTextpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void liçenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }
    }
}
