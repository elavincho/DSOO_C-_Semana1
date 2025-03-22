internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejericicio 4");

        Console.WriteLine("Se trata de implementar un programa que sume los dígitos de un " +
            "número entero no negativo de 4 dígitos. Por ejemplo, la suma de los dígitos del " +
            "3433 es 13.  Para darle un poco más de emoción, el programa no se limitará a " +
            "escribir el resultado de la suma, sino que también escribirá todos los sumandos " +
            "utilizados: 3 + 4 + 3 + 3 = 13.");
        Console.WriteLine("");

        // Variables
        int numero = 0;
        int primerDigito = 0;
        int segundoDigito = 0;
        int tercerDigito = 0;
        int cuartoDigito = 0;
        int suma = 0;

        // Solicitamos que ingrese un número
        Console.WriteLine("Ingrese un Número Entero de 4 Digitos");
        numero = int.Parse(Console.ReadLine());

        // Verificamos que el número ingresado sea correcto
        if (numero > 999 && numero <= 9999)
        {
            // Obtenemos los cuatro digitos
            primerDigito = numero / 1000;
            segundoDigito = (numero /100) % 10;
            tercerDigito = (numero / 10) % 10;
            cuartoDigito = numero % 10;

            // Calculamos la suma de los digitos
            suma = primerDigito + segundoDigito + tercerDigito + cuartoDigito;

            // Mostramos la suma por pantalla
            Console.WriteLine("La suma de los díditos es: ");
            Console.WriteLine("");
            Console.WriteLine(primerDigito + " + " + segundoDigito + " + " + tercerDigito + " + " + cuartoDigito + " = " + suma);
        }
        else
        {
            Console.WriteLine("El número debe ser de 4 dígitos.");
        }
    }
}
    