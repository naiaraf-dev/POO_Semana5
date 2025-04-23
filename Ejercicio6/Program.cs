namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear dos objetos de Persona con diferentes edades
            Persona persona1 = new Persona(25); // Edad de 25 años
            Persona persona2 = new Persona(30); // Edad de 30 años

            // Comparar la edad de persona2 con la de persona1
            persona2.CompararEdad(persona1.Edad); // Pasamos la edad de persona1

            Console.ReadKey();
        }
    }
}
