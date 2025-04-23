namespace Ejercicio7
{
    internal class Vagon : Tren
    {
        // Atributos adicionales para la clase Vagon
        public int Capacidad { get; set; }
        public int CantidadPersonas { get; set; }

        // Constructor
        public Vagon(int capacidad)
        {
            Capacidad = capacidad;
            CantidadPersonas = 0;  // El vagón comienza vacío
        }

        // Método para verificar si el vagón está lleno
        public void VagonLleno()
        {
            if (CantidadPersonas >= Capacidad)
            {
                Console.WriteLine("El vagón está lleno.");
            }
            else
            {
                Console.WriteLine("El vagón no está lleno.");
            }
        }

        // Método para aumentar la cantidad de personas en el vagón
        public void SubirPersonas(int cantidad)
        {
            if (CantidadPersonas + cantidad <= Capacidad)
            {
                CantidadPersonas += cantidad;
                Console.WriteLine($"Han subido {cantidad} personas al vagón.");
            }
            else
            {
                Console.WriteLine("No hay suficiente espacio para esa cantidad de personas.");
            }
        }
    }
}
