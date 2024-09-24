class Laboratorio94
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();
        int numero = aleatorios.GenerarNumero(1, 10);
        Console.WriteLine("Número aleatorio: " + numero);

        int[] arreglo = aleatorios.GenerarArreglo(1, 10, 5);
        Console.WriteLine("Arreglo aleatorio:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }
    }
}