using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec7_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. tip dizi tanimlama
            int[] arr0 = new int[5];
            arr0[0] = 1;

            Console.WriteLine("arr0: " + arr0[0]);

            #endregion

            #region 2. tip dizi tanimlama
            int[] arr1 = { 10, 20, 30, 40, 50 };

            Console.WriteLine("arr1: " + arr1.GetValue(4));

            #endregion

            #region 3. tip dizi tanimlama
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("arr2: " + arr2.GetValue(4));
            #endregion

            #region 4. tip dizi tanimlama
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("arr3: " + arr3.GetValue(4));
            #endregion

            #region 5. tip dizi tanimlama
            int[] arr4 = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("arr4: " + arr4.GetValue(4));
            #endregion

            #region multiarray =>3x3 matris

            int[,] matris = { { 1, 2, 3, 10 }, { 4, 5, 6, 11 }, { 7, 8, 9, 12 } };

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + "\t");

                }
                Console.WriteLine("\n");
            }
            #endregion

            #region Jagged Arrays
            /*Öyle bir dizi olsun ki, dizinin elemanları bir dizi olsun*/
            int[][] arr3 = new int[3][]; //arr3 dizisinin 3 elemanı var.
            //arr3'ün her bir indisinde ayrı diziler var.
            arr3[0] = new int[] { 1, 2, 3 };
            arr3[1] = new int[] { 10, 20, 30, 40, 50 };
            arr3[2] = new int[] { 11, 22 };

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3[i].GetLength(0); j++)
                {
                    Console.Write(arr3[i][j] + "*** \t");
                }
                Console.WriteLine("\n");
            };
            #endregion

            #region Object Array
            /* Farkli turde verileri icinde barindirabilir. 
             */
            object[] arr = { 1, 'e', 3.14, "London" };

            #endregion

            #region Dynamic Array
            dynamic[] alues = { 1, 3.14, "Istanbul" };
            #endregion

            #region Array Sinifi
            /* Array sinifindan int tipinde, bir dizi turettik. 
             * Array sinifinin belirli metot ve ozelliklerini kullanabiliriz.
             * Indexer operatorunu kullanamayiz. Metotlar kullaniriz.
             */
            Array students = new int[5] {1,2,3,4,5};

            #endregion


        }
    }
}
