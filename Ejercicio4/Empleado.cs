namespace Ejercicio4
{
    internal class Empleado
    {
        protected string nombre;
        protected string apellido;
        protected string telefono;
        protected string email;
        protected string dni;
        protected double sueldo;

        // Constructor
        public Empleado(string nombre, string apellido, string telefono, string email, string dni, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.dni = dni;
            this.sueldo = sueldo;
        }

        // Método para mostrar la información básica del empleado
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Teléfono: {telefono}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine($"Sueldo: ${sueldo}");
        }
    }
}
