namespace CalculadoraMovil
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
            this.velocidad_lbl = new System.Windows.Forms.Label();
            this.tiempo_lbl = new System.Windows.Forms.Label();
            this.resultado_lbl = new System.Windows.Forms.Label();
            this.velocidad_txtbx = new System.Windows.Forms.TextBox();
            this.tiempo_txtbx = new System.Windows.Forms.TextBox();
            this.resultado_txtbx = new System.Windows.Forms.TextBox();
            this.calcular_btn = new System.Windows.Forms.Button();
            this.limpiar_btn = new System.Windows.Forms.Button();
            this.salir_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Location = new System.Drawing.Point(109, 21);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(158, 16);
            this.titulo_lbl.TabIndex = 0;
            this.titulo_lbl.Text = "Calculadora de Distancia";
            //this.titulo_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // velocidad_lbl
            // 
            this.velocidad_lbl.AutoSize = true;
            this.velocidad_lbl.Location = new System.Drawing.Point(27, 81);
            this.velocidad_lbl.Name = "velocidad_lbl";
            this.velocidad_lbl.Size = new System.Drawing.Size(86, 20);
            this.velocidad_lbl.TabIndex = 1;
            this.velocidad_lbl.Text = "Velocidad";
            // 
            // tiempo_lbl
            // 
            this.tiempo_lbl.AutoSize = true;
            this.tiempo_lbl.Location = new System.Drawing.Point(27, 118);
            this.tiempo_lbl.Name = "tiempo_lbl";
            this.tiempo_lbl.Size = new System.Drawing.Size(68, 20);
            this.tiempo_lbl.TabIndex = 2;
            this.tiempo_lbl.Text = "Tiempo";
            // 
            // resultado_lbl
            // 
            this.resultado_lbl.AutoSize = true;
            this.resultado_lbl.Location = new System.Drawing.Point(27, 234);
            this.resultado_lbl.Name = "resultado_lbl";
            this.resultado_lbl.Size = new System.Drawing.Size(86, 20);
            this.resultado_lbl.TabIndex = 3;
            this.resultado_lbl.Text = "Resultado";
            // 
            // velocidad_txtbx
            // 
            this.velocidad_txtbx.Location = new System.Drawing.Point(137, 78);
            this.velocidad_txtbx.Name = "velocidad_txtbx";
            this.velocidad_txtbx.Size = new System.Drawing.Size(100, 22);
            this.velocidad_txtbx.TabIndex = 4;
            // 
            // tiempo_txtbx
            // 
            this.tiempo_txtbx.Location = new System.Drawing.Point(137, 112);
            this.tiempo_txtbx.Name = "tiempo_txtbx";
            this.tiempo_txtbx.Size = new System.Drawing.Size(100, 22);
            this.tiempo_txtbx.TabIndex = 5;
            // 
            // resultado_txtbx
            // 
            this.resultado_txtbx.Location = new System.Drawing.Point(137, 228);
            this.resultado_txtbx.Name = "resultado_txtbx";
            this.resultado_txtbx.Size = new System.Drawing.Size(100, 22);
            this.resultado_txtbx.TabIndex = 6;
            // 
            // calcular_btn
            // 
            this.calcular_btn.Location = new System.Drawing.Point(30, 173);
            this.calcular_btn.Name = "calcular_btn";
            this.calcular_btn.Size = new System.Drawing.Size(75, 23);
            this.calcular_btn.TabIndex = 7;
            this.calcular_btn.Text = "Calcular";
            this.calcular_btn.Click += new System.EventHandler(this.calcular_btn_Click);
            this.calcular_btn.UseVisualStyleBackColor = true;
            // 
            // limpiar_btn
            // 
            this.limpiar_btn.Location = new System.Drawing.Point(111, 173);
            this.limpiar_btn.Name = "limpiar_btn";
            this.limpiar_btn.Size = new System.Drawing.Size(75, 23);
            this.limpiar_btn.TabIndex = 8;
            this.limpiar_btn.Text = "Limpiar";
            this.limpiar_btn.Click += new System.EventHandler(this.limpiar_btn_Click);
            this.limpiar_btn.UseVisualStyleBackColor = true;
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(192, 173);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(75, 23);
            this.salir_btn.TabIndex = 9;
            this.salir_btn.Text = "Salir";
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            this.salir_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 371);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.limpiar_btn);
            this.Controls.Add(this.calcular_btn);
            this.Controls.Add(this.resultado_txtbx);
            this.Controls.Add(this.tiempo_txtbx);
            this.Controls.Add(this.velocidad_txtbx);
            this.Controls.Add(this.resultado_lbl);
            this.Controls.Add(this.tiempo_lbl);
            this.Controls.Add(this.velocidad_lbl);
            this.Controls.Add(this.titulo_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Label velocidad_lbl;
        private System.Windows.Forms.Label tiempo_lbl;
        private System.Windows.Forms.Label resultado_lbl;
        private System.Windows.Forms.TextBox velocidad_txtbx;
        private System.Windows.Forms.TextBox tiempo_txtbx;
        private System.Windows.Forms.TextBox resultado_txtbx;
        private System.Windows.Forms.Button calcular_btn;
        private System.Windows.Forms.Button limpiar_btn;
        private System.Windows.Forms.Button salir_btn;
    }
}

