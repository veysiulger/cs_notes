using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec2_type_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String'i Diger Tiplere Donusturmek

            #region Parse method
            /*string str = "256";
            short num=short.Parse(str);
            Console.WriteLine(num*8);*/
            #endregion

            #region Convert method
            /*string str2 = "512";
            int num = Convert.ToInt32(str2);
            Console.WriteLine(num * 10);
            string str3 = "2.18";
            double num2 = Convert.ToDouble(str3);
            Console.WriteLine(num2 * 10);*/
            #endregion

            #endregion

            #region Diger Tipleri, String'e Donusturmek

            #region Convert method
            /*int num3 = 12;
            string str4 = Convert.ToString(num3);
            Console.WriteLine(str4 + " bu bir string toplamadir!");
            Console.WriteLine(str4.GetType());*/
            #endregion

            #region ToString method

            /*int num4 = 12;
            string str5 = num4.ToString();
            Console.WriteLine("string deger:"+str5+"\n"+str5.GetType());*/

            #endregion

            #endregion

            #region Bilincsiz Tur Donusumu
            /*int a = 13;
            double b;
            b = a;*/
            #endregion

            #region Bilincli Tur Donusumu
            /*double a1 = 5000;
            short b1;
            b1 =(short)a1;*/
            #endregion

            #region Tur Donusumunde Cast Etmek
            /*float a2 = 5000;
            int b2 = (short)a2;*/
            #endregion

            #region checked
            //Bilincli tur donusumu yapilirken, bir hata olmussa runtime'da bunu gosterir. 
            /*checked
            {
                int a3 = 50;
                byte b3 = (byte)a3;
                Console.WriteLine(b3);
            }*/
            #endregion

            #region unchecked
            /*unchecked
            {
                int a4 = 1540;
                byte b4 = (byte)a4;
                Console.WriteLine(b4);
            }*/
            #endregion

            #region Cast Ile Char-Number Donusturme (ASCII)
            char karakter = 'A';
            int numVarChar = 35;

            int a_ascii = (int)karakter;
            char varChar = (char)numVarChar;
            Console.WriteLine("A'nin ascii kodu: " + a_ascii + "\n" + "ascii 34:  " + varChar);

            #endregion

            #region TryParse
            /* Eger girilen deger, int'e donusebiliyorsa, isParsed true olur ve 
             * girilen deger number'a atanir. 
             */
            int number;
            bool isParsed = int.TryParse(Console.ReadLine(),out number);
            
            #endregion
        }
    }
}
