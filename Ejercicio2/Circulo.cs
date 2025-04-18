namespace Ejercicio2
{
    internal class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public void CalcularArea()
        {
            area = Math.PI * radio * radio;
        }
    }
}
