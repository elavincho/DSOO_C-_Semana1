internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2 - Semana 1");
        Console.WriteLine("En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. " +
            "El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados. Debe mostrar el nombre y el puntaje " +
            "total de cada participante. Nota: cuando se ingrese FIN en el nombre del participante finaliza nuestro programa.");
        Console.WriteLine("");

        // Atributos
        string nombre;
        double puntuacionTotal = 0;

        // Contante cantidad de jurados = 3
        const int JURADOS = 3;

        // Solicitamos al usuario que ingrese el nombre del participante
        Console.WriteLine("Ingrese el nombre del Participante");
        nombre = Console.ReadLine().ToUpper();

        //Utilizamos un ciclo while con la condición de que el nombre sea distinto de FIN
        while (nombre != "FIN")
        {
            // Utilizamos un ciclo for para solicitar la puntuación de los 3 jurados
            for (int i = 1; i <= JURADOS; i++)
            {
                Console.WriteLine("Ingrese la Puntuación del Jurado " + i + " para " + nombre);

                puntuacionTotal += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine(" * ----- * ----- * ----- * ----- * ----- * ----- * ----- *");
            Console.WriteLine("");

            // Mostramos la puntuación total del participante y su nombre
            Console.WriteLine("Puntuación total del Participante " + nombre + " es : " + puntuacionTotal);

            // Reseteamos la puntuación total
            puntuacionTotal = 0;

            // Solicitamos el nombre para el proximo participante
            Console.WriteLine("Ingrese el nombre del Próximo Participante");
            nombre = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("");
        Console.WriteLine(" * ----- * ----- * ----- * ----- * ----- * ----- * ----- *");
        Console.WriteLine("El Programa Finalizó");
    }
}