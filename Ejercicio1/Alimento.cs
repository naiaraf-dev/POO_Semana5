namespace POO_Semana5
{
    internal class Alimento : Producto
    {
        //Atributos
        public DateTime FechaVencimiento { get; set; }

        //Constructor
        public Alimento(string nomProducto, double precio, int stock, DateTime fechaVencimiento) :
            base(nomProducto, precio, stock)
        {
            this.FechaVencimiento = fechaVencimiento;
        }

        //Métodos
        public void MostrarInfo()
        {
            MostrarDatos();
            Console.WriteLine($"Fecha de vencimiento: {this.FechaVencimiento}");
        }
    }
}
