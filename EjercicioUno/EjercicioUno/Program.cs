internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicio 1 - Semana 1
        /*El precio de los productos no tiene incluido el incremento 
         * del 15% que representa la ganancia del negocio, por lo tanto, 
         * el algoritmo debe calcular el precio final a abonar por un cliente. 
         * Se ingresa el precio del producto y como resultado muestra el 
         * precio de venta.*/


        Console.WriteLine("Ejercicio 1 - Semana 1");
        Console.WriteLine("El precio de los productos no tiene incluido el incremento");
        Console.WriteLine("del 15% que representa la ganancia del negocio, por lo tanto,");
        Console.WriteLine("el algoritmo debe calcular el precio final a abonar por un cliente.");
        Console.WriteLine("Se ingresa el precio del producto y como resultado muestra el");
        Console.WriteLine("precio de venta.");
        Console.WriteLine("");

        double precioProducto;
        const double INCREMENTO = 0.15;
        double importeIncremento;
        double total;

        Console.WriteLine("Ingrese el Precio del Producto:");
        precioProducto = double.Parse(Console.ReadLine());
        importeIncremento = precioProducto * INCREMENTO;
        total = precioProducto + importeIncremento;
        Console.WriteLine("Precio Producto: " + precioProducto);
        Console.WriteLine("Incremento 15%: " + importeIncremento);
        Console.WriteLine("Total: " + total);
    }
}