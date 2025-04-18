using POO_Semana5;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar clase Bebida
            Bebida bebida1 = new Bebida("Coca-Cola", 2500, 25, false);
            bebida1.MostrarInfo();
            Console.WriteLine();
            bebida1.Venta(10);
            Console.WriteLine();

            Bebida bebida2 = new Bebida("Brahma", 1700, 37, true);
            bebida2.MostrarInfo();
            Console.WriteLine();
            bebida2.Venta(26);
            Console.WriteLine();

            //Instaciar clase Alimento
            Alimento alimento1 = new Alimento("Pan integral", 2600, 18, new DateTime(2025, 6, 25));
            alimento1.MostrarInfo();
            Console.WriteLine();
            alimento1.Venta(9);
            Console.WriteLine();

            Alimento alimento2 = new Alimento("Arroz", 1400, 33, new DateTime(2026, 2, 15));
            alimento2.MostrarInfo();
            Console.WriteLine();
            alimento2.Venta(17);
            Console.WriteLine();
        }
    }
}
