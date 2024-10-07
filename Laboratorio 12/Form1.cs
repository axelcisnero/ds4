using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMovil
{
    public partial class Form1 : Form
    {
        // Instancia de la clase Calculos
        Calculos calculos = new Calculos();

        public Form1()
        {
            InitializeComponent();
        }

        // Botón Calcular
        private void calcular_btn_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo, distancia;

            // Validar los valores ingresados usando la clase Calculos
            if (calculos.EsNumeroValido(velocidad_txtbx.Text, out velocidad) && calculos.EsNumeroValido(tiempo_txtbx.Text, out tiempo))
            {
                // Calcular la distancia y mostrar el resultado
                distancia = calculos.CalcularDistancia(velocidad, tiempo);
                resultado_txtbx.Text = distancia.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        // Botón Limpiar
        private void limpiar_btn_Click(object sender, EventArgs e)
        {
            velocidad_txtbx.Text = "";
            tiempo_txtbx.Text = "";
            resultado_txtbx.Text = "";
        }

        // Botón Salir
        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
