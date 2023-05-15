using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9_classes_basic
{

    class Square
    {
        #region Siniflar
        /* Sinif veri yapisi, bir veri modeli sunar. Bu veri modelinden
         * nesneler yaratilir. Siniflar icerisinde, metotlari ve 
         * özellikleri yani degiskenleri barindirir.
         * 
         * 5 adet erisim belirleyicisi vardir. Bunlar;
         * public,
         * private,
         * protected,
         * internal,
         * protected internal

         */
        public int shortEdge;
        public int longEdge;
        #endregion

        #region Constructors
        /* Yapici metotlar, siniftan bir nesne turetildiginde, otomatik 
         * olarak yurutulen mettottur. Bu sayede ilk degerler sinif 
         * uyelerine verilmis olur. 
         * 
         * Biz tanimlamasak bile, her sinifin default bir yapici 
         * metodu vardir. 
         * Yapici metotlarin geriye donus degeri yoktur. 
         * Yapici metot ile, sinif adi ayni olmalidir. 
         * 
         */

        public Square(int a, int b)
        {
            shortEdge = a;
            longEdge = b;
        }

        #endregion

        #region This Kullanimi
        /* İlgili nesnenin, referansini tutar. Sinifin uye 
         * elemanlari icin kullaniriz. 
         */
        /* This yapici metot kullanimi: bu sekilde tanimlanan 
         * yapici metot ilk yapici metodu kullanir. 
         * 
         * public Square(int a):this(12,0) { }
         */

        #endregion

        #region Destructors ve Garbage Collection
        /* Nesne erisimi bitti ise, nesnenin bellekteki varligi gereksizdir. 
         * Bellekte ayirilan alanlar geri idade edilmezse, memory leak 
         * gerceklesebilir.
         * Garbage collection: Bellekte tutulan referans bolgelerini geri 
         * iade eder. Bizden bagimsiz olarak calisir.
         * 
         * 
         * C#da nesnenin kaynagi iki sekilde iade edilir. 
         * 1)   Dispose() medotu
         * 2)   ~ karakteri ile, yikici metot tanimlamak
         * Bir sinifin sadece bir tane yikici metodu olabilir. Yikicilarda
         * kalitim ve overloading yapilmaz.
         * 
         * Main metodu icerisinde nesne varligi devam ettigi surece,
         * yikici metot calismaz. Lakin, main metodunun isi bitti ise,
         * yikici metot calisir. Yani main icerisinde nesne kullanilmaya
         * devam ettigi surece, bellekte yer isgal eder. 
         * 
         * main icinde, nesne ile is bitti ise, once garbage col. devreye girer.
         * girmeden once yikici metodumuz devreye girer.
         * 
         */
        ~Square()
        {
            Console.WriteLine("Yikici metot cagrildi...");
            Console.ReadKey();
        }
        #endregion
        public int calcArea()
        {
            return shortEdge * longEdge;
        }

        public int calcEdge()
        {
            return (2 * shortEdge + 2 * longEdge);
        }

        public double calcDiagonal()
        {
            int result = longEdge * longEdge + shortEdge * shortEdge;

            return Math.Pow(result, 0.5);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesne Tanimlama
            /* Nesne bildirimi 
             * square s1; 
             * biciminde yapilir. Nesnenin tanimlanip, 
             * bellekte alan ayrilmasi icin, new sozcugu kullanilir.
             */
            Square square1 = new Square(12, 4);
            int result1 = square1.calcArea();
            Console.WriteLine($"Dortgen alani: {result1} birim karedir.");
            #endregion


        }
    }
}
