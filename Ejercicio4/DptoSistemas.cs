namespace Ejercicio4
{
    internal class DptoSistemas : Empleado
    {
        private string area;
        private bool tieneTituloRelacionado;
        private bool tieneComputadoraLaboral;
        private int cantidadGenteACargo;

        // Constructor
        public DptoSistemas(string nombre, string apellido, string telefono, string email, string dni, double sueldo,
                            string area, bool tieneTituloRelacionado, bool tieneComputadoraLaboral, int cantidadGenteACargo)
            : base(nombre, apellido, telefono, email, dni, sueldo)
        {
            this.area = area;
            this.tieneTituloRelacionado = tieneTituloRelacionado;
            this.tieneComputadoraLaboral = tieneComputadoraLaboral;
            this.cantidadGenteACargo = cantidadGenteACargo;
        }

        // Método para mostrar la información del empleado en el área de sistemas
        public void MostrarInformacionSistemas()
        {
            MostrarInformacion();
            Console.WriteLine($"Área en Sistemas: {area}");
            Console.WriteLine($"¿Tiene título relacionado al trabajo?: {(tieneTituloRelacionado ? "Sí" : "No")}");
            Console.WriteLine($"¿Tiene computadora laboral a su cargo?: {(tieneComputadoraLaboral ? "Sí" : "No")}");
            Console.WriteLine($"Cantidad de gente a cargo: {cantidadGenteACargo}");
        }
    }
}
