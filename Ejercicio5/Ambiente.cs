namespace Ejercicio5
{
    internal class Ambiente
    {
        // Atributos
        public string SistemaOperativo { get; set; }
        public int Ram { get; set; }
        public string BaseDatos { get; set; }
        public string App { get; set; }

        // Constructor
        public Ambiente(string sistemaOperativo, int ram, string baseDatos, string app)
        {
            SistemaOperativo = sistemaOperativo;
            Ram = ram;
            BaseDatos = baseDatos;
            App = app;
        }

        // Método para verificar si el despliegue es posible
        public void VerificarDespliegue()
        {
            // Verificamos si todos los valores coinciden con los esperados
            if (SistemaOperativo == "linux" && Ram == 4 && BaseDatos == "postgresql" && App == "openjdk")
            {
                Console.WriteLine("El despliegue se puede realizar.");
            }
            else
            {
                Console.WriteLine("No será posible realizar el despliegue.");
            }
        }
    }
}
