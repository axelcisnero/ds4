using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        // Crear una instancia de la clase CalculosMatematicos
        CalculosMatematicos calculos = new CalculosMatematicos();

        // Llamar al método CalculoArea y obtener el resultado
        double area = calculos.CalculoArea(radio);

        // Mostrar el resultado al usuario
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }
}
