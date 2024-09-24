using System;

class Aleatorios
{
    private Random random = new Random();

    public int GenerarNumero(int minimo, int maximo)
    {
        return random.Next(minimo, maximo + 1);
    }

    public int[] GenerarArreglo(int minimo, int maximo, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumero(minimo, maximo);
        }
        return arreglo;
    }
}