namespace POO_Semana5
{
    internal class Bebida : Producto
    {
        //Atributos
        public bool BebidaAlcoholica { get; set; }

        //Constructor
        public Bebida(string nomProducto, double precio, int stock, bool bebidaAlcoholica) :
            base(nomProducto, precio, stock)
        {
            this.BebidaAlcoholica = bebidaAlcoholica;
        }

        //Métodos
        public void MostrarInfo()
        {
            MostrarDatos();
            Console.WriteLine($"¿Es una bebida alcoholica?: {(BebidaAlcoholica ? "SI" : "NO")}");
        }
    }
}
