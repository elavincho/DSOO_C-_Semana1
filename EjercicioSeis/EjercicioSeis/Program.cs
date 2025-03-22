using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 6");
            Console.WriteLine("Tres personas aportan diferente capital a una sociedad y desean saber el valor " +
                "total aportado y qué porcentaje aportó cada una (indicando nombre y porcentaje). Para ello, " +
                "solicitar la carga por teclado del nombre de cada socio, su capital aportado y a partir de " +
                "esto calcular e informar lo requerido previamente .");
            Console.WriteLine("");

            // Variables
            string nombre = "";
            double capital = 0;
            double totalAportado = 0;
            double porcentaje = 0;

            const int SOCIOS = 3;

            // Lista para almacenar nombres y capitales
            List<string> nombres = new List<string>();
            List<double> capitales = new List<double>();

            for (int i = 0; i < SOCIOS; i++)
            {
                // Pedimos el nombre del Socio
                Console.WriteLine($"Datos del Socio {i + 1} : ");
                Console.WriteLine("Nombre del Socio: ");
                nombre = Console.ReadLine().ToUpper();

                // Pedimos el capital aportado
                Console.WriteLine("Ingrese el Capital Aportado: ");
                capital = double.Parse(Console.ReadLine());

                // Agregamos los datos a la lista
                nombres.Add(nombre);
                capitales.Add(capital);
            }
            
            // Calculamos el capital aportado
           foreach(double capitalAp in capitales)
            {
                totalAportado += capitalAp;
            }

            // Mostramos los resultados
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Total aportado: {totalAportado:C}");
            /*El formato :C es un especificador de formato en C# que se usa 
             * para formatear un número como una moneda. Dependiendo de la 
             * configuración regional del sistema, el número se mostrará con 
             * el símbolo de la moneda local, separadores de miles y el formato adecuado.*/

            // Calculamos y mostramos el porcentaje de cada socio
            for (int i = 0;i < nombres.Count;i++)
            {
                porcentaje = (capitales[i] / totalAportado) *100;
                Console.WriteLine($"{nombres[i]} aportó el {porcentaje:F2}%");
            }
            /*El formato :F2 es un especificador de formato en C# que se usa para 
             * formatear un número como un valor decimal con una cantidad fija de 
             * dígitos después del punto decimal. En este caso, el 2 indica que se 
             * mostrarán dos decimales.*/
        }
    }
}
