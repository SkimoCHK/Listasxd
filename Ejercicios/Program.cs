using System;


public class Nodo
{
    public int Valor;       
    public Nodo Siguiente;  

    
    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}


public class ListaEnlazada
{
    public Nodo PrimerNodo;


    public void AgregarAlPrincipio(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.Siguiente = PrimerNodo;
        PrimerNodo = nuevoNodo;
    }


    public void ImprimirLista()
    {
        Nodo actual = PrimerNodo;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public bool EstaVacia()
    {
        return PrimerNodo == null;
    }

    public int Longitud()
    {
        int longitud = 0;
        Nodo actual = PrimerNodo;
        while (actual != null)
        {
            longitud++;
            actual = actual.Siguiente;
        }
        return longitud;
    }

}

class Program
{
    static void Main()
    {
        // Crear una lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar elementos al principio de la lista
        lista.AgregarAlPrincipio(3);
        lista.AgregarAlPrincipio(2);
        lista.AgregarAlPrincipio(1);

        // Imprimir la lista
        Console.WriteLine("Lista después de agregar elementos al principio:");
        lista.ImprimirLista();
    }
}
