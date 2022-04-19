
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.comboBoxSelecione = new System.Windows.Forms.ComboBox();
            this.labelSelecione = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblGridView = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoTextpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liçenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique em OK para proseguir";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(12, 92);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(211, 23);
            this.textResultado.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(75, 191);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(656, 415);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(132, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "abrir nova janela";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // comboBoxSelecione
            // 
            this.comboBoxSelecione.FormattingEnabled = true;
            this.comboBoxSelecione.Items.AddRange(new object[] {
            "SP",
            "PE",
            "RJ"});
            this.comboBoxSelecione.Location = new System.Drawing.Point(12, 142);
            this.comboBoxSelecione.Name = "comboBoxSelecione";
            this.comboBoxSelecione.Size = new System.Drawing.Size(211, 23);
            this.comboBoxSelecione.TabIndex = 4;
            // 
            // labelSelecione
            // 
            this.labelSelecione.AutoSize = true;
            this.labelSelecione.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelecione.Location = new System.Drawing.Point(75, 118);
            this.labelSelecione.Name = "labelSelecione";
            this.labelSelecione.Size = new System.Drawing.Size(79, 21);
            this.labelSelecione.TabIndex = 5;
            this.labelSelecione.Text = "Selecione:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(292, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // lblGridView
            // 
            this.lblGridView.AutoSize = true;
            this.lblGridView.Location = new System.Drawing.Point(334, 45);
            this.lblGridView.Name = "lblGridView";
            this.lblGridView.Size = new System.Drawing.Size(162, 15);
            this.lblGridView.TabIndex = 7;
            this.lblGridView.Text = "Dados da coleção de estados:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTextpToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoTextpToolStripMenuItem
            // 
            this.novoTextpToolStripMenuItem.Name = "novoTextpToolStripMenuItem";
            this.novoTextpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.novoTextpToolStripMenuItem.Text = "Novo Texto";
            this.novoTextpToolStripMenuItem.Click += new System.EventHandler(this.novoTextpToolStripMenuItem_Click);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.textoToolStripMenuItem.Text = "Sair";
            this.textoToolStripMenuItem.Click += new System.EventHandler(this.textoToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.liçenToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // liçenToolStripMenuItem
            // 
            this.liçenToolStripMenuItem.Name = "liçenToolStripMenuItem";
            this.liçenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liçenToolStripMenuItem.Text = "Licença";
            this.liçenToolStripMenuItem.Click += new System.EventHandler(this.liçenToolStripMenuItem_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(578, 45);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(198, 15);
            this.lblHoraAtual.TabIndex = 9;
            this.lblHoraAtual.Text = "Dia e hora atual: 01/01/0000 00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.lblGridView);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelSelecione);
            this.Controls.Add(this.comboBoxSelecione);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textResultado;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox comboBoxSelecione;
        private System.Windows.Forms.Label labelSelecione;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoTextpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liçenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
    }
}

