namespace Parcial_2
{
    partial class frmConvertidor
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
            this.lblGalLit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLitGal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGalLit = new System.Windows.Forms.Button();
            this.btnLitGal = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lbRegistro = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGalLit
            // 
            this.lblGalLit.AutoSize = true;
            this.lblGalLit.Location = new System.Drawing.Point(12, 46);
            this.lblGalLit.Name = "lblGalLit";
            this.lblGalLit.Size = new System.Drawing.Size(104, 16);
            this.lblGalLit.TabIndex = 0;
            this.lblGalLit.Text = "Galones a Litros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblLitGal
            // 
            this.lblLitGal.AutoSize = true;
            this.lblLitGal.Location = new System.Drawing.Point(12, 92);
            this.lblLitGal.Name = "lblLitGal";
            this.lblLitGal.Size = new System.Drawing.Size(104, 16);
            this.lblLitGal.TabIndex = 2;
            this.lblLitGal.Text = "Litros a Galones";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnGalLit
            // 
            this.btnGalLit.Location = new System.Drawing.Point(325, 39);
            this.btnGalLit.Name = "btnGalLit";
            this.btnGalLit.Size = new System.Drawing.Size(75, 23);
            this.btnGalLit.TabIndex = 4;
            this.btnGalLit.Text = "->";
            this.btnGalLit.UseVisualStyleBackColor = true;
            // 
            // btnLitGal
            // 
            this.btnLitGal.Location = new System.Drawing.Point(325, 85);
            this.btnLitGal.Name = "btnLitGal";
            this.btnLitGal.Size = new System.Drawing.Size(75, 23);
            this.btnLitGal.TabIndex = 5;
            this.btnLitGal.Text = "->";
            this.btnLitGal.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(425, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 22);
            this.textBox4.TabIndex = 7;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(254, 199);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(192, 23);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Historial de Conversiones";
            this.btnRegistro.UseVisualStyleBackColor = true;
            //this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click_1);
            // 
            // lbRegistro
            // 
            this.lbRegistro.FormattingEnabled = true;
            this.lbRegistro.ItemHeight = 16;
            this.lbRegistro.Location = new System.Drawing.Point(12, 243);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(655, 180);
            this.lbRegistro.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(254, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(371, 159);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbRegistro);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnLitGal);
            this.Controls.Add(this.btnGalLit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblLitGal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGalLit);
            this.Name = "frmConvertidor";
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGalLit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLitGal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGalLit;
        private System.Windows.Forms.Button btnLitGal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.ListBox lbRegistro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

