namespace Ejercicio7
{
    internal class Tren
    {
        // Atributos
        public int Velocidad { get; private set; }
        public string Estado { get; private set; }

        // Constructor
        public Tren()
        {
            Velocidad = 0;  // El tren comienza parado
            Estado = "Frenado";  // El estado inicial es frenado
        }

        // Método para acelerar el tren
        public void Acelerar(int velocidad)
        {
            Velocidad += velocidad;  // Aumentamos la velocidad
            Estado = "Acelerando";  // El tren ahora está acelerando
            Console.WriteLine($"El tren ha acelerado a {Velocidad} km/h.");
        }

        // Método para frenar el tren
        public void Frenar()
        {
            Velocidad = 0;  // El tren se detiene
            Estado = "Frenado";  // El tren ahora está frenando
            Console.WriteLine("El tren ha frenado.");
        }

        // Método para mostrar el estado del tren
        public void MostrarEstado()
        {
            Console.WriteLine($"Velocidad: {Velocidad} km/h, Estado: {Estado}");
        }
    }
}
