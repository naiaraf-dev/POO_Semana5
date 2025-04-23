namespace Ejercicio4
{
    internal class Programador : DptoSistemas
    {
        private string lenguajeDeProgramacion;
        private string nivel;  // Puede ser "Junior", "SemiSenior", "Senior"
        private int vecesQueTumboProduccion;

        // Constructor
        public Programador(string nombre, string apellido, string telefono, string email, string dni, double sueldo,
                           string area, bool tieneTituloRelacionado, bool tieneComputadoraLaboral, int cantidadGenteACargo,
                           string lenguajeDeProgramacion, string nivel, int vecesQueTumboProduccion)
            : base(nombre, apellido, telefono, email, dni, sueldo, area, tieneTituloRelacionado, tieneComputadoraLaboral, cantidadGenteACargo)
        {
            this.lenguajeDeProgramacion = lenguajeDeProgramacion;
            this.nivel = nivel;
            this.vecesQueTumboProduccion = vecesQueTumboProduccion;
        }

        // Método para mostrar toda la información del programador
        public void MostrarInformacionProgramador()
        {
            MostrarInformacionSistemas();
            Console.WriteLine($"Lenguaje de programación: {lenguajeDeProgramacion}");
            Console.WriteLine($"Nivel: {nivel}");
            Console.WriteLine($"Veces que tumbó producción: {vecesQueTumboProduccion}");
        }
    }
}
