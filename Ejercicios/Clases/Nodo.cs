using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    public class Nodo
    {
        private int _valor;
        private Nodo _siguiente;


        public Nodo(int valor)
        {
            _valor = valor;
            _siguiente = null;
        }


        //Metodo pa agregar un elemento en medio de la lista.
        public Nodo(int valor, Nodo siguiente)
        {
            _valor = valor;
            _siguiente = siguiente;

        }
        public int Valor { get;set; }
        public Nodo Siguiente { get;set;}

    }

    
}
