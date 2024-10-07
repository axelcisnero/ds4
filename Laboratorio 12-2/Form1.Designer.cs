namespace CalcularPromedio
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
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.nota1_lbl = new System.Windows.Forms.Label();
            this.nota2_lbl = new System.Windows.Forms.Label();
            this.nota3_lbl = new System.Windows.Forms.Label();
            this.notaprom_lbl = new System.Windows.Forms.Label();
            this.nota1_txtbx = new System.Windows.Forms.TextBox();
            this.nota2_txtbx = new System.Windows.Forms.TextBox();
            this.nota3_txtbx = new System.Windows.Forms.TextBox();
            this.notaprom_txtbx = new System.Windows.Forms.TextBox();
            this.promedio_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.salir_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Location = new System.Drawing.Point(110, 19);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(98, 16);
            this.titulo_lbl.TabIndex = 0;
            this.titulo_lbl.Text = "Nota Promedio";
            // 
            // nota1_lbl
            // 
            this.nota1_lbl.AutoSize = true;
            this.nota1_lbl.Location = new System.Drawing.Point(31, 76);
            this.nota1_lbl.Name = "nota1_lbl";
            this.nota1_lbl.Size = new System.Drawing.Size(46, 16);
            this.nota1_lbl.TabIndex = 1;
            this.nota1_lbl.Text = "Nota 1";
            // 
            // nota2_lbl
            // 
            this.nota2_lbl.AutoSize = true;
            this.nota2_lbl.Location = new System.Drawing.Point(31, 116);
            this.nota2_lbl.Name = "nota2_lbl";
            this.nota2_lbl.Size = new System.Drawing.Size(46, 16);
            this.nota2_lbl.TabIndex = 2;
            this.nota2_lbl.Text = "Nota 2";
            // 
            // nota3_lbl
            // 
            this.nota3_lbl.AutoSize = true;
            this.nota3_lbl.Location = new System.Drawing.Point(31, 156);
            this.nota3_lbl.Name = "nota3_lbl";
            this.nota3_lbl.Size = new System.Drawing.Size(46, 16);
            this.nota3_lbl.TabIndex = 3;
            this.nota3_lbl.Text = "Nota 3";
            // 
            // notaprom_lbl
            // 
            this.notaprom_lbl.AutoSize = true;
            this.notaprom_lbl.Location = new System.Drawing.Point(31, 266);
            this.notaprom_lbl.Name = "notaprom_lbl";
            this.notaprom_lbl.Size = new System.Drawing.Size(98, 16);
            this.notaprom_lbl.TabIndex = 4;
            this.notaprom_lbl.Text = "Nota Promedio";
            // 
            // nota1_txtbx
            // 
            this.nota1_txtbx.Location = new System.Drawing.Point(135, 73);
            this.nota1_txtbx.Name = "nota1_txtbx";
            this.nota1_txtbx.Size = new System.Drawing.Size(100, 22);
            this.nota1_txtbx.TabIndex = 5;
            // 
            // nota2_txtbx
            // 
            this.nota2_txtbx.Location = new System.Drawing.Point(135, 113);
            this.nota2_txtbx.Name = "nota2_txtbx";
            this.nota2_txtbx.Size = new System.Drawing.Size(100, 22);
            this.nota2_txtbx.TabIndex = 6;
            // 
            // nota3_txtbx
            // 
            this.nota3_txtbx.Location = new System.Drawing.Point(135, 153);
            this.nota3_txtbx.Name = "nota3_txtbx";
            this.nota3_txtbx.Size = new System.Drawing.Size(100, 22);
            this.nota3_txtbx.TabIndex = 7;
            // 
            // notaprom_txtbx
            // 
            this.notaprom_txtbx.Location = new System.Drawing.Point(135, 266);
            this.notaprom_txtbx.Name = "notaprom_txtbx";
            this.notaprom_txtbx.Size = new System.Drawing.Size(100, 22);
            this.notaprom_txtbx.TabIndex = 8;
            // 
            // promedio_btn
            // 
            this.promedio_btn.Location = new System.Drawing.Point(6, 204);
            this.promedio_btn.Name = "promedio_btn";
            this.promedio_btn.Size = new System.Drawing.Size(95, 23);
            this.promedio_btn.TabIndex = 9;
            this.promedio_btn.Text = "Promedio";
            this.promedio_btn.UseVisualStyleBackColor = true;
            this.promedio_btn.Click += new System.EventHandler(this.promedio_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(108, 204);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(94, 23);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(208, 204);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(90, 23);
            this.salir_btn.TabIndex = 11;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 396);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.promedio_btn);
            this.Controls.Add(this.notaprom_txtbx);
            this.Controls.Add(this.nota3_txtbx);
            this.Controls.Add(this.nota2_txtbx);
            this.Controls.Add(this.nota1_txtbx);
            this.Controls.Add(this.notaprom_lbl);
            this.Controls.Add(this.nota3_lbl);
            this.Controls.Add(this.nota2_lbl);
            this.Controls.Add(this.nota1_lbl);
            this.Controls.Add(this.titulo_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Label nota1_lbl;
        private System.Windows.Forms.Label nota2_lbl;
        private System.Windows.Forms.Label nota3_lbl;
        private System.Windows.Forms.Label notaprom_lbl;
        private System.Windows.Forms.TextBox nota1_txtbx;
        private System.Windows.Forms.TextBox nota2_txtbx;
        private System.Windows.Forms.TextBox nota3_txtbx;
        private System.Windows.Forms.TextBox notaprom_txtbx;
        private System.Windows.Forms.Button promedio_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button salir_btn;
    }
}

