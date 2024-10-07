using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        // Instancia de la clase CalculoTriangulo
        CalculoTriangulo calculo = new CalculoTriangulo();

        public Form1()
        {
            InitializeComponent();
        }

        // Botón para calcular el semiperímetro
        private void semiperimetro_btn_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, semiperimetro;

            // Validar los valores ingresados
            if (calculo.EsNumeroValido(ladoa_txtbx.Text, out ladoA) && calculo.EsNumeroValido(ladob_txtbx.Text, out ladoB) && calculo.EsNumeroValido(ladoc_txtbx.Text, out ladoC))
            {
                // Calcular el semiperímetro y mostrar el resultado
                semiperimetro = calculo.CalcularSemiperimetro(ladoA, ladoB, ladoC);
                semiperimetro_txtbx.Text = semiperimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        // Botón para calcular el área
        private void area_btn_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, area;

            // Validar los valores ingresados
            if (calculo.EsNumeroValido(ladoa_txtbx.Text, out ladoA) && calculo.EsNumeroValido(ladob_txtbx.Text, out ladoB) && calculo.EsNumeroValido(ladoc_txtbx.Text, out ladoC))
            {
                // Calcular el área y mostrar el resultado
                area = calculo.CalcularArea(ladoA, ladoB, ladoC);
                area_txtbx.Text = area.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        // Botón para limpiar los campos
        private void reset_btn_Click(object sender, EventArgs e)
        {
            ladoa_txtbx.Text = "";
            ladob_txtbx.Text = "";
            ladoc_txtbx.Text = "";
            semiperimetro_txtbx.Text = "";
            area_txtbx.Text = "";
        }

        // Botón para salir de la aplicación
        private void salida_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
