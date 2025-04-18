namespace Ejercicio3
{
    internal class Cuenta
    {
        protected string nro_cuenta;
        protected string nombre;
        protected double saldo;
        protected string estado_cuenta;

        // Constructor para inicializar la cuenta
        public Cuenta(string nro_cuenta, string nombre)
        {
            this.nro_cuenta = nro_cuenta;
            this.nombre = nombre;
            this.saldo = 0;
            this.estado_cuenta = "Activa";  // Suponemos que la cuenta está activa por defecto
        }

        // Método para ingresar monto en la cuenta
        public void IngresarMonto(int montoASumar)
        {
            if (montoASumar > 0)
            {
                saldo += montoASumar;
                Console.WriteLine($"Se han ingresado ${montoASumar}. Nuevo saldo: ${saldo}");
            }
            else
            {
                Console.WriteLine("El monto a sumar debe ser positivo.");
            }
        }

        // Método para retirar monto de la cuenta
        public void RetirarMonto(int montoARestar)
        {
            if (montoARestar > 0 && montoARestar <= saldo)
            {
                saldo -= montoARestar;
                Console.WriteLine($"Se han retirado ${montoARestar}. Nuevo saldo: ${saldo}");
            }
            else
            {
                Console.WriteLine("Monto no válido para retirar.");
            }
        }

        // Método para mostrar la información de la cuenta
        public void MostrarInformacion()
        {
            Console.WriteLine($"Número de cuenta: {nro_cuenta}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Saldo: ${saldo}");
            Console.WriteLine($"Estado de la cuenta: {estado_cuenta}");
        }
    }
}
