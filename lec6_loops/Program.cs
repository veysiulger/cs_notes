using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indexEnd = 9;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int i = 1;

            int[] arr = { 10, 20, 30, 40, 50 };

            #region for
            for (int j = 0; j <= indexEnd; j++)
            {
                sum1 = sum1 + j;

            }
            Console.WriteLine("for operation -> sum: " + sum1);

            #endregion

            #region foreach
            /*
                koleksiyonlarin icinde dolasmak icin kullanilabilir.
            */
            foreach (int x in arr)
            {
                Console.WriteLine("Dizinin " + i + ".ci elemani: " + x);
                i++;
            }
            #endregion

            #region while 

            while (sum2 == 0)
            {
                sum2 = 12 * 5;


            }
            Console.WriteLine("while operation -> sum: " + sum2);


            #endregion

            #region do-while
            string strNum;
            int numB = default;
            int result = default;
            do
            {
                Console.WriteLine("num degerini giriniz!");
                strNum = Console.ReadLine();
                numB = Convert.ToInt32(strNum);
                result = 12 * 5;
            }
            while (numB == 0); //num=0 oldukca, do bloklari calisir.
            Console.WriteLine("do-while operation -> result: " + result);
            #endregion

            #region Donguden kacis
            /* Kosul saglandiginda, dongunun bitmesini istiyorsak 
             * if bloklari icerisinde break komutunu kullaniriz.*/
            for (int j = 0; j <= indexEnd; j++)
            {
                if (j == 2)
                {
                    break;
                }
                else
                {
                    sum3 = sum3 + j;

                }
                Console.WriteLine("for operation with break -> sum: " + sum3);

            }


            #endregion
            Console.ReadLine();
        }
    }
}
