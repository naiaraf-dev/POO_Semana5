namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear cuenta mayor
            CuentaMayor cuentaMayor = new CuentaMayor("12345", "Juan Perez", 25);
            cuentaMayor.IngresarMonto(1000);
            cuentaMayor.RetirarMonto(500);
            cuentaMayor.VerificarEdad();
            cuentaMayor.MostrarInformacion();

            Console.WriteLine();

            // Crear cuenta menor
            CuentaMenor cuentaMenor = new CuentaMenor("67890", "Ana Garcia", 17);
            cuentaMenor.IngresarMonto(500);
            cuentaMenor.RetirarMonto(100);
            cuentaMenor.VerificarEdad();
            cuentaMenor.MostrarInformacion();

            Console.WriteLine();

            // Crear cuenta estudiante
            CuentaEstudiante cuentaEstudiante = new CuentaEstudiante("11223", "Carlos Lopez", "UTN");
            cuentaEstudiante.IngresarMonto(2000);
            cuentaEstudiante.MostrarUniversidad();
            cuentaEstudiante.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
