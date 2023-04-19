using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec8_methods
{
    internal class Program
    {
        #region Temeller
        /* Tum metotlar, bir sinif icerisinde bildirilmelidir.
         * Bu sebeple, bir metoda erisilecek ise, metot hangi sinifta 
         * bildirilmisse, o sinifin turunde bir nesne yaratilmali ve o 
         * nesne uzerinden, ilgili metoda erisim saglanmalidir. 
         * 
         * Lakin;
         * static olarak tanimlanan metotlara erismek icin, 
         * nesne yaratmaya gerek yoktur. 
         *
         * Metot icinde metot bildirilemez.
         */
        #endregion

        #region Deger Tipli ve Referans Tipli Gonderilen Parametreler
        /* Deger tipli veriler metotlara aktarilirken, bit seviyesinde 
         * kopyalanarak aktarilir. Ornegin, int tipinde bir değeri, parametre 
         * olarak metota atadigimizda, metot icinde bu parametreyi degistirirsek 
         * ana degiskeni degistirmemektedir. 
         * Ancak referans tipli parametre olsaydi, ve bu parametre metot icinde 
         * degismesi, orijinal nesneyi de degistirir. Mesela diziler referans 
         * tiplidir. Bunu parametre olarak bir metota gonderirsek, dizinin tum elemanlari 
         * metota parametre olarak gitmez. Dizinin sadece refensi parametre olarak gonderilir. 
         * 
         */
        static void valueType1(int numb)
        {
            numb = 12;
        }

        static void valueType2(string[] str)
        {
            str[0] = "ankara";
        }
        #endregion

        #region ref ve out
        /* ref sozcugu, deger tipleri, parametre olarak aktarirken, 
         * referanslarini aktarmaya yarar. */
        static void valueWithRef1(ref int myNum1)
        {
            myNum1 = 30;
        }
        /* out kullanimi, ref ile aynidir. sadece ilk deger verme 
         * sarti yoktur. 
         */
        static void valueWithOut1(out int myNum2)
        {
            myNum2 = 320;
        }

        #endregion

        #region void method (Geri Donus Degeri Olmayan Methods)
        /* void anahtar sozcugu, geriye deger dondurmeyen 
         * metotlarda kullanilmaktadir. 
         * */
        static void voidFunc(string str)
        {
            Console.WriteLine($"{str} I am void func :)");

        }

        #endregion

        #region ref return
        /* Eger metodun deger yerine, referans dondurmek istersek
         * ref return kullaniriz.*/

        public static ref int valueWithRefReturn(int[] myArr)
        {

            return ref myArr[2];

        }
        #endregion

        static void Main(string[] args)
        {
            string str = "Hello World!";
            voidFunc(str);


            #region deger tipli gonderilen parametre
            /* Fonksiyon icinde, parametre degismesine ragmen,
             * ana degiskeni degistirmedi ve ekranda iki tane 
             * 5 yazdi. a1 degiskeni aktarilirken, kopyasi aktarildi. 
             * Orijinal degisken korundu.*/
            Console.WriteLine("deger tipli gonderilen parametre:");
            int a1 = 5;
            Console.WriteLine(a1);
            valueType1(a1);
            Console.WriteLine(a1);
            #endregion


            #region  referans tipli gonderilen parametre
            /* Parametre olarak gonderilen dizinin adresidir.
             * Bu sebeple ilgili fonksiyon icinde, degisken degisirse, 
             * orijinal degisken de degisir. */
            Console.WriteLine("referans tipli gonderilen parametre");
            string[] a2 = { "izmir", "istanbul" };
            Console.WriteLine(a2[0]);
            valueType2(a2);
            Console.WriteLine(a2[0]);
            #endregion

            #region ref keywords
            /*ref keyword tanımlaması yapılıyorsa, İLK DEĞER MUTLAKA VERİLMELİDİR! */
            int a3 = 10;
            Console.WriteLine("without ref operation: " + a3); // konsolda 10 yazar
            valueWithRef1(ref a3); //parametre gönderirken ref YAZILMALIDIR !
            Console.WriteLine("ref operation: " + a3); //Artık konsolda 30 yazar.
            #endregion

            #region out keywords
            /*out keyword tanımlamasında ilk değer verme şartı yoktur.
            Bunun dışında, ref ile aynı işleve sahiptir. */
            int a4 = 8;
            Console.WriteLine("without out operation: " + a4); // konsolda 8 yazar
            valueWithOut1(out a4); //parametre gönderirken out YAZILMALIDIR !
            Console.WriteLine("out operation: " + a4); //Artık konsolda 320 yazar.
            #endregion

            #region ref return
            int[] my_arr = { 1, 2, 3, 4, 5 };
            ref int newMyNumb = ref valueWithRefReturn(my_arr);
            Console.WriteLine("ref return operation: " + newMyNumb);
            #endregion
            Console.Read();
        }
    }
}
