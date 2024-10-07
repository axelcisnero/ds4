using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPromedio
{
    public partial class Form1 : Form
    {
        // Instancia de la clase CalculosProm
        CalculosProm calculos = new CalculosProm();

        public Form1()
        {
            InitializeComponent();
        }

        // Botón para calcular el promedio
        private void promedio_btn_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;

            // Validar los valores ingresados usando la clase CalculosProm
            if (calculos.EsNumeroValido(nota1_txtbx.Text, out nota1) && calculos.EsNumeroValido(nota2_txtbx.Text, out nota2) && calculos.EsNumeroValido(nota3_txtbx.Text, out nota3))
            {
                // Calcular el promedio y mostrar el resultado
                promedio = calculos.CalcularPromedio(nota1, nota2, nota3);
                notaprom_txtbx.Text = promedio.ToString("F2"); // Mostrar el promedio con dos decimales
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        // Botón para limpiar las entradas
        private void reset_btn_Click(object sender, EventArgs e)
        {
            nota1_txtbx.Text = "";
            nota2_txtbx.Text = "";
            nota3_txtbx.Text = "";
            notaprom_txtbx.Text = "";
        }

        // Botón para salir de la aplicación
        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
