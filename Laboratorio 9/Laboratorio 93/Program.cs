using System;

class Laboratorio93
{
    static void Main()
    {
        Console.Write("Ingrese el lado 1: ");
        int lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 2: ");
        int lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 3: ");
        int lado3 = int.Parse(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No es un triángulo válido.");
        }
    }
}
