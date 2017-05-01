using System;

namespace Arboles
{
    public class Nodo
    {
        public Nodo(int valor, Nodo nodoIzquiero, Nodo nodoDerecho)
        {
            Valor = valor;
            NodoIzquierdo = nodoIzquiero;
            NodoDerecho = nodoDerecho;
        }

        public int Valor { get; set; }
        public Nodo NodoDerecho { get; set; }
        public Nodo NodoIzquierdo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodo">Nodo el cual imprimiremos recusivamente in-order</param>
        public static void Traversal(Nodo nodo)
        {
            MakeTraversal(nodo.NodoIzquierdo);
            Console.Out.Write($"{nodo.Valor}-");
            MakeTraversal(nodo.NodoDerecho);
        }

        private static bool IsNodeNull(Nodo nodo)
        {
            return nodo == null;
        }

        private static void MakeTraversal(Nodo nodo)
        {
            if (!IsNodeNull(nodo))
                Traversal(nodo);
        }
    }
}
