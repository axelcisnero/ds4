class Laboratorio95
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();
        int[] arregloNoRepetido = aleatorios.ArregloNoRepetido(1, 10, 5);

        Console.WriteLine("Arreglo sin números repetidos:");
        foreach (int num in arregloNoRepetido)
        {
            Console.WriteLine(num);
        }
    }
}
