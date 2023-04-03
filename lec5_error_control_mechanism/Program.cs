using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec5_error_control_mechanism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Runtime Error
            /* Calisma zamani hatalari. Kodun semantiginde, syntax'ta hata 
             * olmaz. Kod calisma esnasinda OS mudahalesi ile, hata verir. 
             * Olasi hatalari goz onune alarak, son kullaniciya hitaben, 
             * daha anlasilir bir sekilde olasi hatalar duzenlenmelidir.
             * 
             * try-cathc: Bu yapilanma ile uygulama surecinde, olasi hatalari
             * yonetebiliriz. Hatalari manipule etmeye yarar. Amaci,
             * kullaniciya hatalari hissettirmeden bildirmek.
             * 
             * try{ Olasi hata verebilecek kodlar buraya yazilir. }
             * catch{ try icinde hata veren kod orada kesilir, catch'den devam eder.}
             * 
             * NOT: Bu yapilanma, icindeki kodlari surekli denetler.
             * Yani hep tetiklenmektedir. Bu sebeple maliyet olusturur. Bu sebeple 
             * luzumsuz kodlari try icerisine yazmamamiz gerekiyor. Sadece 
             * hata verme ihtimali olan kodlar buraya gomulmelidir.
             */
            int sayi1=1, sayi2=1;
            try
            {   
                Console.WriteLine("birinci sayi:");
                 sayi1=int.Parse(Console.ReadLine());//gelen sayi int'e cevrildi.

                Console.WriteLine("ikinci sayi:");
                 sayi2 = int.Parse(Console.ReadLine());

               
                /* Kullanici burada str girebilir. 
                 * O halde uygulama patlayacaktir. 
                 */
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Sadece tam sayi giriniz!");
                Console.WriteLine("Hata mesaji: "+ex.Message);

            }
            //Birden fazla catch eklenebilir.
            //Exeption: Tum hatalarin ecdadi. En sona yazilir.
            /* catch(DivideByZeroExeption ex){
             * 
             * } 
             */
            Console.WriteLine("Carpim: " + sayi1 * sayi2);
            #endregion
            Console.ReadLine();
        }
    }
}
