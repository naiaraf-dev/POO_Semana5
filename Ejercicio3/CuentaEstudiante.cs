namespace Ejercicio3
{
    internal class CuentaEstudiante : Cuenta
    {
        private string universidad;

        public CuentaEstudiante(string nro_cuenta, string nombre, string universidad) : base(nro_cuenta, nombre)
        {
            this.universidad = universidad;
        }

        // Método adicional que podría ser útil, dependiendo de la lógica (aunque no se pide explícitamente)
        public void MostrarUniversidad()
        {
            Console.WriteLine($"Universidad: {universidad}");
        }
    }
}
