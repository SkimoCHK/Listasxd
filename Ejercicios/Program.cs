using System;
using Ejercicios.Clases;
class Program
{

    static void Main()
    {
        
        ListaEnlazada lista = new ListaEnlazada();

        
        lista.AgregarAlPrincipio(3);
        lista.AgregarAlPrincipio(2);
        lista.AgregarAlPrincipio(1);

        
        Console.WriteLine("Lista después de agregar elementos al principio:");
        lista.ImprimirLista();


    }
}
