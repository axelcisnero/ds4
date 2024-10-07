using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedio
{
    public class CalculosProm
    {
        // Método para calcular el promedio de tres notas
        public double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        // Método para validar que los valores sean numéricos
        public bool EsNumeroValido(string input, out double numero)
        {
            return double.TryParse(input, out numero);
        }
    }
}
