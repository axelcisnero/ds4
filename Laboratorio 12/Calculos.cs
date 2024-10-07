using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMovil
{
    public class Calculos
    {
        // Método para calcular la distancia
        public double CalcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }

        // Método para validar que los valores sean numéricos
        public bool EsNumeroValido(string input, out double numero)
        {
            return double.TryParse(input, out numero);
        }
    }
}
