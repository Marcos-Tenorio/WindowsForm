
using System;

namespace WinFormsApp1
{
    partial class FrmShow
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
            this.txtRuntime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRuntime
            // 
            this.txtRuntime.AutoSize = true;
            this.txtRuntime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRuntime.Location = new System.Drawing.Point(271, 103);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(229, 37);
            this.txtRuntime.TabIndex = 0;
            this.txtRuntime.Text = "Escrita em runtme";
            this.txtRuntime.Click += new System.EventHandler(this.txtRuntime_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRuntime);
            this.Name = "FrmShow";
            this.Text = "FrmShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtRuntime_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public System.Windows.Forms.Label txtRuntime;
    }
}