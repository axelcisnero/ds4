using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        // Crear una instancia de la clase CalculosMatematicos
        CalculosMatematicos calculos = new CalculosMatematicos();

        // Llamar al método Calcular y obtener el resultado
        int resultado = calculos.Calcular(num1, num2);

        // Mostrar el resultado al usuario
        Console.WriteLine($"El resultado de la operación ({num1} + {num2}) * ({num1} - {num2}) es: {resultado}");
    }
}
