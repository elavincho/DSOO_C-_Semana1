using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Modifica la salida de la resolución del punto 2. " +
                "Se pide mostrar un mensaje que indique si cada participante llegó " +
                "a la última etapa o no.");

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

                // Mostramos la puntuación total del participante y su nombre
                Console.WriteLine("Puntuación total del Participante " + nombre + " es : " + puntuacionTotal);

                // Indicamos si el participante llego a la última etapa o no

                if (puntuacionTotal >= 80)
                {
                    Console.WriteLine("¡¡Felicidades!! El participante " + nombre + " pasó a la próxima etapa");
                }
                else
                {
                    Console.WriteLine("El participante " + nombre + " NO pasó a la proxima etapa");
                }

                // Reseteamos la puntuación total
                puntuacionTotal = 0;
                
                Console.WriteLine("");
                Console.WriteLine(" * ----- * ----- * ----- * ----- * ----- * ----- * ----- *");
                Console.WriteLine("");

                // Solicitamos el nombre para el proximo participante
                Console.WriteLine("Ingrese el nombre del Próximo Participante");
                nombre = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("");
            Console.WriteLine(" * ----- * ----- * ----- * ----- * ----- * ----- * ----- *");
            Console.WriteLine("El Programa Finalizó");

        }
    }
}
