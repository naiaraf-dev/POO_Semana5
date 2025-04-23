namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un tren
            Tren tren = new Tren();
            tren.Acelerar(60);  // Aceleramos el tren a 60 km/h
            tren.MostrarEstado();  // Mostramos el estado del tren

            tren.Frenar();  // Frenamos el tren
            tren.MostrarEstado();  // Mostramos el estado después de frenar

            // Crear un vagón
            Vagon vagon = new Vagon(100);  // Capacidad de 100 personas
            vagon.SubirPersonas(50);  // Suben 50 personas
            vagon.VagonLleno();  // Verificamos si el vagón está lleno

            vagon.SubirPersonas(60);  // Intentamos subir 60 personas más
            vagon.VagonLleno();  // Verificamos si el vagón está lleno nuevamente

            Console.ReadKey();
        }
    }
}
