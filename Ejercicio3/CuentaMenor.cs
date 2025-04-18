namespace Ejercicio3
{
    internal class CuentaMenor : Cuenta
    {
        private int edad;

        public CuentaMenor(string nro_cuenta, string nombre, int edad) : base(nro_cuenta, nombre)
        {
            this.edad = edad;
        }

        // Método para verificar si la persona es menor de 18 años
        public void VerificarEdad()
        {
            if (edad < 18)
            {
                Console.WriteLine("La persona es menor de 18 años.");
            }
            else
            {
                Console.WriteLine("La persona no es menor de 18 años.");
            }
        }
    }
}
