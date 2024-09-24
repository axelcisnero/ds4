using System;

class Aleatorios
{
    private Random random = new Random();

    public int GenerarNumero(int minimo, int maximo)
    {
        return random.Next(minimo, maximo + 1);
    }

    public int[] ArregloNoRepetido(int minimo, int maximo, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        int index = 0;

        while (index < cantidad)
        {
            int num = GenerarNumero(minimo, maximo);
            if (Array.IndexOf(arreglo, num) == -1)
            {
                arreglo[index] = num;
                index++;
            }
        }

        return arreglo;
    }
}