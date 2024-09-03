using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el largo del rectángulo: ");
        double largo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = double.Parse(Console.ReadLine());

        // Crear una instancia de la clase CalculosMatematicos
        CalculosMatematicos calculos = new CalculosMatematicos();

        // Llamar al método CalculoPerimetroRectangulo y obtener el resultado
        double perimetro = calculos.CalculoPerimetroRectangulo(largo, ancho);

        // Mostrar el resultado al usuario
        Console.WriteLine($"El perímetro del rectángulo con largo {largo} y ancho {ancho} es: {perimetro}");
    }
}
