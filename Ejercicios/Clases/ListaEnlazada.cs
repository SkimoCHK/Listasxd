using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    public class ListaEnlazada
    {

        public Nodo PrimerNodo;

        //PARTE 1
        public void AgregarAlPrincipio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = PrimerNodo;
            PrimerNodo = nuevoNodo;
        }

        public void AgregarALMedio(int valor, Nodo siguiente)
        {

            Nodo nuevoNodo = new Nodo(valor);


        }

        //PARTE 2

        public bool ComprobarSiEstaVacio()
        {

            if(PrimerNodo == null)
            {
                return true;
            }

            return false;

        }

        public void Imprimir()
        {
            if(ComprobarSiEstaVacio())
            {

                Console.WriteLine("Ta vacía mi loco, dele pa fuera");

            }

            Nodo actual = PrimerNodo;
            while (actual != null)
            {
                Console.Write($"{actual.Valor}");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }




        public int Longitud()
        {
            if (ComprobarSiEstaVacio())
            {
                Console.WriteLine("Ta vacia mi loco dele pa fuera");
            }

            int contador = 0;
            Nodo actual = PrimerNodo;
            while (actual != null)
            {

                contador ++;
                actual = actual.Siguiente;

            }

            return contador + 1;



        }




    }
}
