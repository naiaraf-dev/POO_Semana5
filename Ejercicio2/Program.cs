namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(10, 5);
            t.CalcularArea();
            t.MostrarArea();

            Cuadrado c = new Cuadrado(4);
            c.CalcularArea();
            c.MostrarArea();

            Circulo ci = new Circulo(3);
            ci.CalcularArea();
            ci.MostrarArea();

            Console.ReadKey();
        }
    }
}
