using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Heaps.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrenge
            int[] array = { 67, 19, 14, 9, 76, 54, 23, 12, 72, 17, 50 };
            var heap = new Heap(array);
            //Act
            if (heap.GetMax() != 76)
            {
                throw new Exception("Valor maximo incorrecto");
            }
            //Assert
        }
    }
}
