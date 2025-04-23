namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programador
            Programador programador = new Programador("Juan", "Perez", "123456789", "juan.perez@email.com", "12345678", 5000,
                                                      "Desarrollo Backend", true, true, 5,
                                                      "C#", "Senior", 2);
            programador.MostrarInformacionProgramador();

            Console.WriteLine();

            // Crear un empleado de sistemas (sin detalles adicionales)
            DptoSistemas empleadoSistemas = new DptoSistemas("Maria", "Lopez", "987654321", "maria.lopez@email.com", "87654321", 4000,
                                                            "Redes", false, true, 3);
            empleadoSistemas.MostrarInformacionSistemas();

            Console.WriteLine();

            // Crear un empleado general
            Empleado empleado = new Empleado("Carlos", "Gomez", "555555555", "carlos.gomez@email.com", "11223344", 3500);
            empleado.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
