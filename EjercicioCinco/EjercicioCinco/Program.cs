using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");
            Console.WriteLine("Resolver la consiga del punto 4 con la particularidad que el número puede " +
                "tener cualquier cantidad de dígitos, es decir, puede ser un número de dos dígitos como un " +
                "número de 6 dígitos. Tomá la codificación anterior e introducí los cambios que sean necesarios.");

            // Variables
            int numero = 0;
            int suma = 0;
            int digito = 0;
            string sumandos = "";

            // Solicitamos que ingrese un número
            Console.WriteLine("Ingrese un Número Entero");
            numero = int.Parse(Console.ReadLine());

            // Verificamos que el número ingresado sea correcto
            if (numero > 0)
            {
                // Convertimos el número a una cadena para procesar cada dígito
                string numeroString = numero.ToString();
                
                // Recorremos cada dígito
                for (int i = 0; i < numeroString.Length; i++)
                {
                    // Obtenemos el dígito actual
                    digito = int.Parse(numeroString[i].ToString());

                    // Sumamos el dígito
                    suma += digito;

                    // Construimos la cadena de sumandos
                    if(i > 0)
                    {
                        sumandos += " + ";
                    }
                    sumandos += digito;
                }
                // Mostramos el resultado
                Console.WriteLine("La suma de los números es: ");
                Console.WriteLine($"{sumandos} = {suma}");
                /*El signo $ al inicio de una cadena permite utilizar la interpolación 
                 * de cadenas*/
                // $"...": Indica que la cadena que sigue es una cadena interpolada.
                // Las llaves { } se usan para incluir expresiones o variables que serán
                // evaluadas y convertidas a texto.
            }
            else
            {
                Console.WriteLine("El número debe ser positivo.");
            }


        }
    }
}
