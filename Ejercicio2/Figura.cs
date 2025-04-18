namespace Ejercicio2
{
    internal class Figura
    {
        protected double area;

        public void MostrarArea()
        {
            if (area > 0)
            {
                Console.WriteLine($"El área es: {area:F2}");
            }
            else
            {
                Console.WriteLine("El área aún no fue calculada.");
            }
        }
    }
}
