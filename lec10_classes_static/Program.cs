using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec10_classes_static
{
    #region Static Uyeler
    /* Statik uyelere ulasmak icin, siniftan 
     * nesne olusturmaya gerek yoktur. 
     * 
     * Ilgili siniftaki static olmayan alanlara, metotlara 
     * erisim gerekiyorsa nesne referansi gerekir. Yani,
     * statik uyelere, statik metotlardan erisebiliriz.
     * 
     * 
     * NOT:Bir sinif statik olarak tanimlanirsa, tum uyeleri static 
     * olmaktadir.Zorunlu olmamakla birlikte iyi bir kod yazim tekniğidir.
     * */
    #endregion
    class Operation
    {
        #region Static Variables
        /* Static degiskenlere sinif adi ile ulasiriz.
         * Herhangi bir nesne uzerinden static degiskenlere erisilemez */

        public static int a;
        static public int b;

        #endregion

        #region Static methods
        /* Statik metotlara ulasmak icin sinif adini kullaniriz. 
         * Statik metotlara nesneler uzerinden erisemeyiz.
         * 
         * NOT:Nesneler uzerinden is yapmiyorsak, ilgili metot
         * static tanimlanmalidir.
         */
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return sum;
        }
        #endregion

        #region Static Constructors
        /* Sinifta static degiskenler uzerinde islem yapilacak ise,
         * static yapicilar kullanilir. Static yapici metot, ilk
         * nesne tanimlandiginda ya da static metot tetiklendiginde
         * bir kez calisir.
         * 
         * Statik yapicilar parametre almazlar ve erisim belirleyicileri
         * yoktur.
         * 
         */
        static Operation()
        {
            Console.WriteLine("Statik yapici calisti...");
        }
        #endregion

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int result = default;

            //Sinif adi ile static metota erisim
            result = Operation.Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"Toplam: {result}");

            //sinif adi ile static degiskene erisim
            int numA = default;
            numA = Operation.a = 12;
            Console.WriteLine($"Sayi A: {numA}");


            Console.ReadKey();

        }
    }
}
