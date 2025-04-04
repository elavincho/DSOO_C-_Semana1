using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerTele
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Instanciamos el domicilio
            Domicilio domicilio = new Domicilio("Jonte", 5299, "Monte Castro");

            // Instanciamos a las personas
            Persona primeraPersona = new Persona("Camila", domicilio.ToString());
            Persona segundaPersona = new Persona("Facundo", domicilio.ToString());

            // Instanciamos el televisor
            Televisor televisor = new Televisor("Samsung", "Oled 8k", 85, false, 1);

            Console.WriteLine("Ejercicio Televisor");
            Console.WriteLine("");

            // El método Main de la clase Test que instancie lo siguiente y luego lo muestre:
            // 1. Un televisor que le pertenece a Facundo y a Camila
            Console.WriteLine("Este Televisor pertenece a: " + primeraPersona.Nombre + " y " + segundaPersona.Nombre);

            Console.WriteLine("");

            // 2. Ambos viven juntos en Jonte 5299, Monte Castro
            Console.WriteLine("Ellos viven juntos en la calle: " + domicilio.ToString());

            // 3. Que tanto Facundo como Camila, en distintos momentos, puedan realizar diferentes operaciones sobre mismo televisor
            // (tener siempre en cuenta el estado del televisor por ejemplo, no se puede cambiar de canal si se encuentra apagado).



            string salir = "";
            while (!salir.Equals("SI"))
            {
                Console.WriteLine("");
                Console.WriteLine("Que deseas hacer:");
                Console.WriteLine("1. Encender/Apagar Televisor");
                Console.WriteLine("2. Cambiar de Canal (Subir un Canal)");
                Console.WriteLine("3. Ir al Canal (Ingresar N° de Canal)");
                Console.WriteLine("4. Conocer que Canal estas viendo");
                Console.WriteLine("5. Conocer si el Televisor esta Encendido o Apagado");
                Console.WriteLine("6. Salir");
                Console.WriteLine("");
                
                int opcion;
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        televisor.cambiarEstado();
                        
                        break;
                    case 2:
                        if (televisor.Estado == false)
                        {
                            Console.WriteLine("Televisor apagado");
                        }
                        else if (televisor.Estado == true)
                        {
                            televisor.cambiarCanal();
                        }
                        break;
                    case 3:
                        if (televisor.Estado == false)
                        {
                            Console.WriteLine("Televisor apagado");
                        }
                        else if (televisor.Estado == true)
                        {
                            Console.WriteLine("Ingrese el N° del canal al que desea cambiar: (1-150)");
                            int nroCanal = int.Parse(Console.ReadLine());
                            televisor.cambiarCanal(nroCanal);
                        }
                        break;
                    case 4:
                        if (televisor.Estado == false)
                        {
                            Console.WriteLine("Televisor apagado");
                        }
                        else if (televisor.Estado == true)
                        {
                            televisor.obtenerCanalActual();
                        }
                        break;
                    case 5:
                        televisor.verPrendido();
                        break;
                    case 6:
                        Console.WriteLine("¿Deseas Salir? (SI/NO)");
                        salir = Console.ReadLine().ToUpper();
                        if (salir.Equals("SI")) {
                            Console.WriteLine("¡Finalizó el programa!");
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción valida");
                        break;
                }
            }
        }
    }
}
