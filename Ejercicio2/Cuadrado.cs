namespace Ejercicio2
{
    internal class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public void CalcularArea()
        {
            area = lado * lado;
        }
    }
}
