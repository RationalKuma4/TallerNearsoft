namespace Heaps
{
    interface IHeap
    {
        int GetMax();
        int GetMin();
        /// <summary>
        /// Al recibir un elemento ordena el arbol para insertar el nuevo elemento
        /// la condicion para el reordenamiento es dependiente del tipo de heap que se quiera min o max
        /// </summary>
        /// <returns></returns>
        int[] HeapSort();
    }
}
