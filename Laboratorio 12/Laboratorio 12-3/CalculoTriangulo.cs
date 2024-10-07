using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    public class CalculoTriangulo
    {
        // Método para calcular el semiperímetro
        public double CalcularSemiperimetro(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB + ladoC) / 2;
        }

        // Método para calcular el área usando la fórmula de Herón
        public double CalcularArea(double ladoA, double ladoB, double ladoC)
        {
            double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);
            return Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
        }

        // Método para validar que los valores sean numéricos
        public bool EsNumeroValido(string input, out double numero)
        {
            return double.TryParse(input, out numero);
        }
    }
}
