
namespace WinFormsApp1
{
    partial class FrmSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobre));
            this.textBoxSobre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSobre
            // 
            this.textBoxSobre.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSobre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSobre.Enabled = false;
            this.textBoxSobre.Location = new System.Drawing.Point(129, 38);
            this.textBoxSobre.Multiline = true;
            this.textBoxSobre.Name = "textBoxSobre";
            this.textBoxSobre.Size = new System.Drawing.Size(538, 60);
            this.textBoxSobre.TabIndex = 0;
            this.textBoxSobre.Text = resources.GetString("textBoxSobre.Text");
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSobre);
            this.Name = "FrmSobre";
            this.Text = "FrmSobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSobre;
    }
}