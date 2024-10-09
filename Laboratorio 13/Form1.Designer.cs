using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_13
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.productos_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar y desconectar de SQL Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productos_listbox
            // 
            this.productos_listbox.FormattingEnabled = true;
            this.productos_listbox.ItemHeight = 16;
            this.productos_listbox.Location = new System.Drawing.Point(178, 168);
            this.productos_listbox.Name = "productos_listbox";
            this.productos_listbox.Size = new System.Drawing.Size(290, 228);
            this.productos_listbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.productos_listbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ListBox productos_listbox;
    }
}

