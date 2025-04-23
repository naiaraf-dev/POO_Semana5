namespace Ejercicio6
{
    internal class Persona
    {
        // Atributo
        public int Edad { get; set; }

        // Constructor
        public Persona(int edad)
        {
            Edad = edad;
        }

        // Método para comparar la edad de dos personas
        public void CompararEdad(int edadOtraPersona)
        {
            if (Edad > edadOtraPersona)
            {
                Console.WriteLine("Soy mayor que la otra persona.");
            }
            else if (Edad < edadOtraPersona)
            {
                Console.WriteLine("Soy menor que la otra persona.");
            }
            else
            {
                Console.WriteLine("Tengo la misma edad que la otra persona.");
            }
        }
    }
}
