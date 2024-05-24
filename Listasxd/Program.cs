namespace Listasxd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            // Agregar elementos a la lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            // Acceder a elementos de la lista por índice
            Console.WriteLine("Elemento en el índice 1: " + numeros[1]); // Salida: 20

            int numero10 = numeros.Find(n => n == 10);

            Console.WriteLine($"La lista si tiene un elemento con un valor {numero10}");

            // Iterar sobre la lista
            Console.WriteLine("Elementos de la lista:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Insertar un elemento en una posición específica
            numeros.Insert(1, 15); // Insertar el número 15 en el índice 1

            // Eliminar un elemento
            numeros.Remove(20); // Eliminar el número 20 de la lista

            // Eliminar un elemento en una posición específica
            numeros.RemoveAt(0); // Eliminar el primer elemento de la lista

            // Verificar si un elemento está presente en la lista
            if (numeros.Contains(30))
            {
                Console.WriteLine("La lista contiene el número 30.");
            }
            else
            {
                Console.WriteLine("La lista no contiene el número 30.");
            }
        }
    }
}
