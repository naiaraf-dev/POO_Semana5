namespace POO_Semana5
{
    internal class Producto
    {
        //Atributos
        public string NomProducto { get; private set; }
        public double Precio { get; set; }
        public int Stock { get; private set; }

        //Constructor
        public Producto(string nomProducto, double precio, int stock)
        {
            this.NomProducto = nomProducto;
            this.Precio = precio;
            this.Stock = stock;
        }

        //Métodos
        public void Venta(int cantVendida)
        {
            if (cantVendida <= this.Stock)
            {
                this.Stock -= cantVendida;
                Console.WriteLine($"Se han vendido {cantVendida} unidades de {this.NomProducto}.");
            } else
            {
                Console.WriteLine("No hay stock suficiente para realizar esta venta.");
            }

            Console.WriteLine($"Ahora quedan en stock: {this.Stock} unidades de {this.NomProducto}");
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre del Producto: {this.NomProducto}, Precio: ${this.Precio}, Stock: {this.Stock}");
        }
    }
}
