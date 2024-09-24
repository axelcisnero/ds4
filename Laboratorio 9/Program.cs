using System;

class Laboratorio91
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto (valor positivo): ");
        float precio = float.Parse(Console.ReadLine());

        Console.Write("Ingrese la forma de pago (efectivo o tarjeta): ");
        string formaPago = Console.ReadLine().ToLower();

        if (formaPago == "tarjeta")
        {
            Console.Write("Ingrese el número de cuenta (16 dígitos): ");
            string numeroCuenta = Console.ReadLine();
            if (numeroCuenta.Length == 16)
            {
                Console.WriteLine("Pago procesado con tarjeta.");
            }
            else
            {
                Console.WriteLine("Número de cuenta inválido.");
            }
        }
        else
        {
            Console.WriteLine("Pago procesado en efectivo.");
        }
    }
}
