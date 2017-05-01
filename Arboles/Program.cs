using System;

namespace Arboles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nodoCinco = new Nodo(9, null, null);
            var nodoSeis = new Nodo(14, null, null);
            var nodoSiete = new Nodo(19, null, null);
            var nodoCuatro = new Nodo(23, nodoSiete, null);
            var nodoDiez = new Nodo(67, null, null);
            var nodoOcho = new Nodo(54, null, nodoDiez);
            var nodoNueve = new Nodo(76, null, null);

            var nodoTres = new Nodo(12, nodoCinco, nodoSeis);
            var nodoDos = new Nodo(72, nodoOcho, nodoNueve);
            var nodoUno = new Nodo(17, nodoTres, nodoCuatro);

            var raiz = new Nodo(50, nodoUno, nodoDos);
            Nodo.Traversal(raiz);

            Console.In.ReadLine();
        }
    }
}
