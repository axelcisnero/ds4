using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("No ha introducido un dígito válido");
            num = -1;
        }
        catch (OverflowException)
        {
            Console.WriteLine("El número introducido es muy grande");
            num = -1;
        }

        Console.WriteLine(num); // Esta línea ahora está dentro del bloque Main
    }
}
