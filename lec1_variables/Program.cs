using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec1_variables
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            #region Temeller
            /* Yazdigimiz program calisirken, RAM'den veri alarak/vererek
             * islem yapar. Yani, veriler RAM'de tutulur. Uygulamamiz DB icerse
             * bile, islem esnasinda, yine RAM kullanilir. 
             */
            #endregion

            #region String Interpolation Ozelligi
			int varAa=12;	
			Console.WriteLine($" varAa= {varAa} ",varAa);
            Console.WriteLine($"{0},{1}","str1","str2");
			#endregion

			#region Degisken Turleri
            /* Priimitive Type: Deger turlu degisken. Degisken, RAM uzerinde 
             * tutulurken degisken turu bildirilmelidir.
             * Reference Type(Referans Turlu Degiskenler): RAM uzerinde, nesnelerin
             * tutulmasi.
             */

            #endregion

            #region Primitive Control
            /* Bir Degisken tipinin primitive olup olmadigini kontrol
             * etmek icin:*/

            //Console.WriteLine(typeof(int).IsPrimitive);
            #endregion

            #region degisken Yazim Kurallari
            //class Program       Sinif adlari buyuk harfle baslar.
            //class ProgramData   Sona gelen kelime de buyuk harfle baslayabilir.
            //int showResult()    Metotlar(functions) da camelCase'dir.
            //int productName     Degisken bildirimleri, camelCase stil.
            //int productID       Kisaltmalar buyuk harfle yazilip, degiskene eklenebilir.
            //string @static      @ kullanimi.
            #endregion

            #region Deger Atama

            // int variableName; bellekte int tipinde, adi variableName olan alan ayrildi.
            //float variableList = 10.34f; //10.34F
            //double variableList = 10.34d; //10.34D
            // decimal variableList = 10.34m; //10.34M
            //İnt sayi = 1_000_000; //tire ile yazim kolayligi (literal duzenleme)
            /* tuple kullanimi; Tek bir syntax ile, birden fazla veri tanımlamayı sağlar.
             * (int a, string b, float c) z;
             * Z isimli bir tuple oluşturduk.
            */

            #endregion

            #region Default Deger Atama
            /* Main icerisinde tanimladigimiz degiskenlere ilk degerleri
             * atanmasi gerekir. Bu manuel olarak yapilir.
             * 
             * float variableList=default;
             * 
             * Class icerisinde, bir degisken tanimlanirsa, ilk degeri otomatik 
             * olarak default atanir.
             */
            #endregion

            #region Const
            /* Sabitler: RAM uzerindeki statik alanda tutulurlar. 
             * Diger degiskenlerin aksine, stack veya heap uzerinde tutulmazlar.
             * Statik bir yapilanma oldugu icin, heryerden erisilebilirdir
             * const double E=2.18; 
             */
            #endregion

            #region Object Turu (Boxing/Unboxing)
            /*Object: Butun veri tiplerinde object tanimlamasi
             * yapabiliriz.Burada boxing ve unboxing dedigimiz kavram
             * ortaya cikmaktadir.
             */

            //string isim="Mehmet"; 
            //int kimlikID=12;
            //Bunu object ile de tanimlayabilirdik:

            //object isim="Mehmet";
            //object kimlikID=12;

            /* object ile tanimlanan degiskenler, boxing edilmis
             * olurlar. Yani ilgili veri, RAM'de nesne turunde tutulurlar. 
             * Ancak verinin ozunu icerisinde saklamaya devam ederler.
             * Yani;
             * object isim="Mehmet " dedigimizde, isim degiskeninin string oldugunu
             * icerisinde bilgi olarak saklar. Bunu saklamasinin nedeni, 
             * ilgili degisken tekrar unboxing edildiginde, ozundeki veri tipinin
             * tekardan ortaya cikmasi gerekliligidir. Cast operatoru ile, unboxing
             * islemi yapilabilir.
             */
            int a = 10;
            object b = a; //object tipinde b degiskeni tanimlandi.
            Console.WriteLine((int)b);//b degiskeni, object turunden, int'e cevrildi.

            /* NOT: Bir degiskene boxing uygulanmissa, o degisken ile, matematiksel ve
             * metinsel islemler yapilamaz. O sebeple, cast operatoru ile, 
             * unboxing istemi uygulanmalidir.
             */

            #endregion

            #region Var Keyword
            /* var: Bir keyword'tur. Bir veri turu degildir. Var ile tanimli bir 
             * degiskene atama yapildiginda, atanan verinin turune burunmektedir.
             */
            var varA = 12;

            /* varA artik int tipindedir. Ve int tipinde devam eder. Sonrasinda int disinda
             * atama yapilirsa, hata verir. Eger en basta string bir atama yapilsa idi, 
             * o zaman da varA string olur idi. Compiler der ki, bunun
             * turu budur. Bu isi compiler yurutur.
             * 
             * var ile object arasindaki fark;
             * var bir keyword'tur. Object ise bir nesne turudur.*/

            #endregion

            #region dynamic Keyword
            /* dynamic ile runtime asamasinda, verilen degerin
             * turune burunmektedir. 
             * dynamic a=15; denilirse, a degiskeni, uygulama derlenip calistirildiginda,
             * a degiskeni, ilgli degerin turune donusturulur. Dynamic kritik noktalarda kullanilir.
             * Runtime asamasinda esnek davranir.
            */
            dynamic x = "visual studio";
            Console.WriteLine(x.GetType()); //dynamic string olur
            x = 12;
            Console.WriteLine(x.GetType());  //dynamic int tipine bürünür.

            /* NOT: dynamic keyword'unun kararsiz davrandigini unutma.*/
            #endregion

            #region Deep Copy
            /* Bir degiskenin degerinin, baska bir degiskene tasinma islemi.
             * Eldeki verimiz klonlanmaktadir. Deger turlu degiskenler birbirlerine 
             * atanirken default olarak deep copy gecerlidir.
             * 
             */
            int myVarA = 12;
            int myVarB =myVarA; //myVarB artik 12 olur. 
            myVarA = 15;//myVarA degisse bile myVarB degismez.

            #endregion

            #region Shallow Copy
            /* Ilgili deger, degisirse, shallow copy yapilan degisken de 
             * degisir. Bellekte birden fazla referans tek bir veriye isaret eder. 
             * Reference turlu degiskenler de varsayilandir.
             *
             * Ref keyword ile, primitive degiskenlere de shallow copy 
             * uygulayabiliriz. 
             */
            #endregion

            #region Null ve Empty
            /* NULL: Bir degisken/nullable/referans null ile tanimlanmissa, o degisken 
             * bellekte alan tahsis etmemistir. 
             * 
             * EMPTY: Bir degisken/nullable/referans empty ile tanimlanmissa, o degiskenin 
             * degeri yoktur ancak bellekte alan kaplar.
             * 
             */
            string strA = string.Empty;
            #endregion
        }

    }
}
