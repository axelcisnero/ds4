namespace Triangulo
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
            this.ladoa_lbl = new System.Windows.Forms.Label();
            this.ladob_lbl = new System.Windows.Forms.Label();
            this.ladoc_lbl = new System.Windows.Forms.Label();
            this.semiperimetro_lbl = new System.Windows.Forms.Label();
            this.area_lbl = new System.Windows.Forms.Label();
            this.ladoa_txtbx = new System.Windows.Forms.TextBox();
            this.ladob_txtbx = new System.Windows.Forms.TextBox();
            this.ladoc_txtbx = new System.Windows.Forms.TextBox();
            this.semiperimetro_txtbx = new System.Windows.Forms.TextBox();
            this.area_txtbx = new System.Windows.Forms.TextBox();
            this.semiperimetro_btn = new System.Windows.Forms.Button();
            this.area_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.salida_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ladoa_lbl
            // 
            this.ladoa_lbl.AutoSize = true;
            this.ladoa_lbl.Location = new System.Drawing.Point(12, 20);
            this.ladoa_lbl.Name = "ladoa_lbl";
            this.ladoa_lbl.Size = new System.Drawing.Size(180, 16);
            this.ladoa_lbl.TabIndex = 0;
            this.ladoa_lbl.Text = "Ingresa la longitud del lado A";
            // 
            // ladob_lbl
            // 
            this.ladob_lbl.AutoSize = true;
            this.ladob_lbl.Location = new System.Drawing.Point(12, 61);
            this.ladob_lbl.Name = "ladob_lbl";
            this.ladob_lbl.Size = new System.Drawing.Size(180, 16);
            this.ladob_lbl.TabIndex = 1;
            this.ladob_lbl.Text = "Ingresa la longitud del lado B";
            // 
            // ladoc_lbl
            // 
            this.ladoc_lbl.AutoSize = true;
            this.ladoc_lbl.Location = new System.Drawing.Point(12, 102);
            this.ladoc_lbl.Name = "ladoc_lbl";
            this.ladoc_lbl.Size = new System.Drawing.Size(180, 16);
            this.ladoc_lbl.TabIndex = 2;
            this.ladoc_lbl.Text = "Ingresa la longitud del lado C";
            // 
            // semiperimetro_lbl
            // 
            this.semiperimetro_lbl.AutoSize = true;
            this.semiperimetro_lbl.Location = new System.Drawing.Point(12, 233);
            this.semiperimetro_lbl.Name = "semiperimetro_lbl";
            this.semiperimetro_lbl.Size = new System.Drawing.Size(147, 16);
            this.semiperimetro_lbl.TabIndex = 3;
            this.semiperimetro_lbl.Text = "Calcular Semiperimetro";
            // 
            // area_lbl
            // 
            this.area_lbl.AutoSize = true;
            this.area_lbl.Location = new System.Drawing.Point(12, 278);
            this.area_lbl.Name = "area_lbl";
            this.area_lbl.Size = new System.Drawing.Size(118, 16);
            this.area_lbl.TabIndex = 4;
            this.area_lbl.Text = "Área del Triángulo";
            // 
            // ladoa_txtbx
            // 
            this.ladoa_txtbx.Location = new System.Drawing.Point(213, 17);
            this.ladoa_txtbx.Name = "ladoa_txtbx";
            this.ladoa_txtbx.Size = new System.Drawing.Size(100, 22);
            this.ladoa_txtbx.TabIndex = 5;
            // 
            // ladob_txtbx
            // 
            this.ladob_txtbx.Location = new System.Drawing.Point(213, 55);
            this.ladob_txtbx.Name = "ladob_txtbx";
            this.ladob_txtbx.Size = new System.Drawing.Size(100, 22);
            this.ladob_txtbx.TabIndex = 6;
            // 
            // ladoc_txtbx
            // 
            this.ladoc_txtbx.Location = new System.Drawing.Point(213, 99);
            this.ladoc_txtbx.Name = "ladoc_txtbx";
            this.ladoc_txtbx.Size = new System.Drawing.Size(100, 22);
            this.ladoc_txtbx.TabIndex = 7;
            // 
            // semiperimetro_txtbx
            // 
            this.semiperimetro_txtbx.Location = new System.Drawing.Point(213, 227);
            this.semiperimetro_txtbx.Name = "semiperimetro_txtbx";
            this.semiperimetro_txtbx.Size = new System.Drawing.Size(100, 22);
            this.semiperimetro_txtbx.TabIndex = 8;
            // 
            // area_txtbx
            // 
            this.area_txtbx.Location = new System.Drawing.Point(213, 272);
            this.area_txtbx.Name = "area_txtbx";
            this.area_txtbx.Size = new System.Drawing.Size(100, 22);
            this.area_txtbx.TabIndex = 9;
            // 
            // semiperimetro_btn
            // 
            this.semiperimetro_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.semiperimetro_btn.Location = new System.Drawing.Point(12, 155);
            this.semiperimetro_btn.Name = "semiperimetro_btn";
            this.semiperimetro_btn.Size = new System.Drawing.Size(141, 29);
            this.semiperimetro_btn.TabIndex = 10;
            this.semiperimetro_btn.Text = "Semiperimetro";
            this.semiperimetro_btn.Click += new System.EventHandler(this.semiperimetro_btn_Click);
            this.semiperimetro_btn.UseVisualStyleBackColor = true;
            // 
            // area_btn
            // 
            this.area_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.area_btn.Location = new System.Drawing.Point(159, 155);
            this.area_btn.Name = "area_btn";
            this.area_btn.Size = new System.Drawing.Size(144, 29);
            this.area_btn.TabIndex = 11;
            this.area_btn.Text = "Area";
            this.area_btn.Click += new System.EventHandler(this.area_btn_Click);
            this.area_btn.UseVisualStyleBackColor = true;
            //this.area_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(309, 155);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(144, 29);
            this.reset_btn.TabIndex = 12;
            this.reset_btn.Text = "Reset";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // salida_btn
            // 
            this.salida_btn.Location = new System.Drawing.Point(459, 155);
            this.salida_btn.Name = "salida_btn";
            this.salida_btn.Size = new System.Drawing.Size(144, 29);
            this.salida_btn.TabIndex = 13;
            this.salida_btn.Text = "Salida";
            this.salida_btn.Click += new System.EventHandler(this.salida_btn_Click);
            this.salida_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salida_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.area_btn);
            this.Controls.Add(this.semiperimetro_btn);
            this.Controls.Add(this.area_txtbx);
            this.Controls.Add(this.semiperimetro_txtbx);
            this.Controls.Add(this.ladoc_txtbx);
            this.Controls.Add(this.ladob_txtbx);
            this.Controls.Add(this.ladoa_txtbx);
            this.Controls.Add(this.area_lbl);
            this.Controls.Add(this.semiperimetro_lbl);
            this.Controls.Add(this.ladoc_lbl);
            this.Controls.Add(this.ladob_lbl);
            this.Controls.Add(this.ladoa_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ladoa_lbl;
        private System.Windows.Forms.Label ladob_lbl;
        private System.Windows.Forms.Label ladoc_lbl;
        private System.Windows.Forms.Label semiperimetro_lbl;
        private System.Windows.Forms.Label area_lbl;
        private System.Windows.Forms.TextBox ladoa_txtbx;
        private System.Windows.Forms.TextBox ladob_txtbx;
        private System.Windows.Forms.TextBox ladoc_txtbx;
        private System.Windows.Forms.TextBox semiperimetro_txtbx;
        private System.Windows.Forms.TextBox area_txtbx;
        private System.Windows.Forms.Button semiperimetro_btn;
        private System.Windows.Forms.Button area_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button salida_btn;
    }
}

