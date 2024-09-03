public class CalculosMatematicos
{
    // Método que realiza la operación (a + b) * (a - b)
    public int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }

    // Método que calcula el área de un círculo dado su radio
    public double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2); // Área = π * r^2
    }
}
