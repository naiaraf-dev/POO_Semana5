namespace Ejercicio2
{
    internal class Triangulo : Figura
    {
        private double baseT;
        private double altura;

        public Triangulo(double baseT, double altura)
        {
            this.baseT = baseT;
            this.altura = altura;
        }

        public void CalcularArea()
        {
            area = (baseT * altura) / 2;
        }
    }
}
