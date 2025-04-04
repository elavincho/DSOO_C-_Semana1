using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerTele
{
    internal class Televisor
    {
        private string marca;
        private string modelo;
        private int cantPulgadas;
        private bool estado;
        private int nroCanalReproduciendo;

        public Televisor(string marca, string modelo, int cantPulgadas, bool estado, int nroCanalReproduciendo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cantPulgadas = cantPulgadas;
            this.estado = estado;
            this.nroCanalReproduciendo = nroCanalReproduciendo;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantPulgadas { get => cantPulgadas; set => cantPulgadas = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int NroCanalReproduciendo { get => nroCanalReproduciendo; set => nroCanalReproduciendo = value; }


        public int obtenerCanalActual()
        {
            // Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.
            Console.WriteLine("Estas viendo el canal: " + nroCanalReproduciendo);
            return nroCanalReproduciendo;
        }

        public bool cambiarCanal(int canal)
        {
            if (canal <= 0)
            {
                canal = 1;
            }
            else if (canal > 150)
            {
                canal = 150;
            }
            // Cambia el canal al número de canal que reciba por parámetro
            nroCanalReproduciendo = canal;
            Console.WriteLine("Ahora estas viendo el canal: " + canal);

            return true;
        }

        public bool cambiarCanal()
        {
            // Cambia el canal incrementando en uno al que se está reproduciendo actualmente. Si llega al tope de 150, debe comenzar por el primero.
            if (nroCanalReproduciendo >= 1 && nroCanalReproduciendo <= 149)
            {

                Console.WriteLine("Estas viendo el canal " + nroCanalReproduciendo);
                nroCanalReproduciendo++;
                Console.WriteLine("Cambiaste al canal " + nroCanalReproduciendo);
                return true;
            }
            else if (nroCanalReproduciendo >= 150)
            {
                Console.WriteLine("Estas viendo el canal " + nroCanalReproduciendo);
                nroCanalReproduciendo = 1;
                Console.WriteLine("Cambiaste al canal " + nroCanalReproduciendo);
                return true;
            }
            return true;
        }

        public bool verPrendido()
        {
            // Informa con un verdadero si el televisor está encendido o falso en caso contrario.
            if (estado == true)
            {
                Console.WriteLine("El televisor esta encendido.");
                return true;
            }
            else
            {
                Console.WriteLine("El televisor esta apagado.");
                return false;
            }

        }

        public void cambiarEstado()
        {
            // Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.
            if (estado == true)
            {
                Console.WriteLine("El televisor esta encendido.");
                Console.WriteLine("¡Apagando televisor!");
                estado = false;
            }
            else
            {
                estado = true;
                Console.WriteLine("Encendiendo televisor...");
                nroCanalReproduciendo = 1;
                Console.WriteLine("Estas viendo el Canal " + nroCanalReproduciendo);
            }

        }
    }
}
