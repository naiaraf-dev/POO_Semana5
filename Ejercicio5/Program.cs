namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de Ambiente para cada uno de los entornos
            Ambiente desarrollo = new Ambiente("linux", 4, "postgresql", "openjdk");
            Ambiente testing = new Ambiente("linux", 4, "postgresql", "openjdk");
            Ambiente preproduccion = new Ambiente("windows", 8, "mysql", "openjdk");  // Este no cumple con la configuración
            Ambiente produccion = new Ambiente("linux", 4, "postgresql", "openjdk");

            // Verificar despliegue para cada ambiente
            Console.WriteLine("Verificando ambiente de Desarrollo:");
            desarrollo.VerificarDespliegue();

            Console.WriteLine("\nVerificando ambiente de Testing:");
            testing.VerificarDespliegue();

            Console.WriteLine("\nVerificando ambiente de Preproducción:");
            preproduccion.VerificarDespliegue();

            Console.WriteLine("\nVerificando ambiente de Producción:");
            produccion.VerificarDespliegue();

            Console.ReadKey();
        }
    }
}
