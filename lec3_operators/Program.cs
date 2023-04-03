using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 2;

            #region Karsilastirma
            // <(küçüklük)
            // >(büyüklük)
            // <=(küçük veya eşitlik)
            // >=(büyük veya eşitlik)
            // ==(eşitlik)
            bool vars = a == b;
            #endregion

            #region Mantiksal

            //ve => &&
            //veya => ||
            //yada => ^

            bool vars2 = (a == b) || (a <= b);
            Console.WriteLine(vars2);

            #endregion

            #region Ternary

            string result = a == b ? "a, b'ye esittir." : a + " ve " + b + " esit degildir.";
            Console.WriteLine(result);

            #endregion

            #region Member Access
            /*i degerimizi yazip nokta koyunca, bazi uyeler 
             * gosterilir, editor tarafından. Bu nokta operatoru,
             * uye erisim op'dir.
             */
            int i = 23;
            var var1 = i.ToString();
            Console.WriteLine(i.GetType());
            #endregion

            #region Cast Operatoru      
            //1) Boxing, unboxing
            object x = 123; //boxing
            int x_ = (int)x;//unboxing
            //2) Bilincli tur donusumu
            int y = 3;
            short y_ = (short)y;
            //3) ASCII degerini verme(Char=>int veya int=>char)
            int ascii = 23;
            char charASCII = (char)ascii;
            //4) Polimorfizm durumunda, base class referansiyla
            //isaretlenen bir nesneyi, kendi turunde de elde 
            //edebilmemizi saglamaktadir.
            #endregion

            #region Typeof, sizeof
            //sizeof(): Meitnsel keyword. Verilen turun bellekte
            //kac byte kapladigini dondurur.
            Console.WriteLine("int :" + sizeof(int));
            Console.WriteLine("long :" + sizeof(long));
            //typeof operatoru, ilgili turun type'ini vermektedir.
            //Hangi tur icin kullanilirsa, o turle ilgili bilgiler
            //getirilir. reflection kavraminda da kullanilir.

            Type typeDEC = typeof(decimal);
            //decimal'e ait butun bilgiler, typeDEC degerine atanir.
            Console.WriteLine("t turu:" + typeDEC);
            Console.WriteLine(typeDEC.IsPrimitive);
            Console.WriteLine(typeDEC.IsClass);
            #endregion

            #region Default Op
            //belirtilen tipin varsayilan olarak hangi degere sahip oldugunu gosterir.
            //string=>null
            //bool=>false
            //char=>\0
            //reference=>null
            //sayisal=>0
            Console.WriteLine(default(Programs));
            //bosluk gozukur. Yani degersizdir.

            int var_a = default;//int tipinin default degerini atadik var_a'ya
            int var_b = default(int);
            #endregion

            #region Is operatoru
            // boxing yapilan bir degerin ozturu merak ediliyorsa,
            // is operatoru ile kontrol edilir.
            // is operatoru, bool turunde geriye deger dondurur.
            object varUnknown = "awe23";
            bool statevarUnknown = varUnknown is int;
            Console.WriteLine("varUnknown's state is: " + statevarUnknown);

            //is null

            int varChar;//deger turlu degiskenlere null atanamaz!!
            string strNULL = null; //referans turlu degiskenlere null atanabilir.
            bool strIsNULL = strNULL is null; //referans turlu degiskenleri kontrol edebiliriz.
            Console.WriteLine("strNULL's state is: " + strIsNULL);
            #endregion

            #region As Operatoru
            /*cast operatorunun alternatifidir. Sadece unboxing icin kullanabiliriz.
              deger turlu degiskenlerde as operatoru kullanilamaz.
              referans turlu degiskenlerde calisabilir. 
              Unboxing yaparken uygun olmayan deger icin hata vermek yerine
              null olarak donus yapar. Cast operatoru olsaydi, hata verirdi.
              Geriye donus tipi bool'dur. 
            */
            object xVariable = "13";
            string yVariable = xVariable as string;
            Programs zPrograms = xVariable as Programs;
            Console.WriteLine(yVariable.GetType());
            Console.WriteLine(zPrograms is null);
            #endregion

            #region Nullable Operatörü ?
            /* Değer türlü değişkenlere null ataması yapamıyorduk.
             * Null ataması yapabilmek
             * için, ? (soru işareti) operatörü kullanılmalıdır.
             */

            int? variableA = null;
            bool? variableBOOL = null;
            /* variableA deger turlu olmasina ragmen, referans turluymus gibi hareket
             * edebilir.
             */
            Console.WriteLine(variableA is null);

            // as operatörünün kullanılması:
            /* as operatöründe nullable olan türler ile çalışıyorduk. O sebeple,
             * deger türlü değişkenleri nullable yapmamız gerekiyor.
             */
            object variableB = 123;
            int? varB = variableB as int?;
            #endregion

            #region Null-Coalescing ??
            /* Elimizdeki degişkenin null olma durumu varsa, null yerine,
             * başka bir değeri göstermek isteyebiliriz.
            */

            string variableD = null;

            int? variableF = 1;//nullable yaptik.

            var variableStateInt = variableF ?? 0;

            string variableState = variableD ?? "helloWorld";
            Console.WriteLine(variableState);
            Console.WriteLine(variableStateInt);

            #endregion

            #region Null Coalescing Assignment (c#->8.0)
            /*Elimizdeki değişken null ise, ekrana "helloworld"
            yazdırılır ve aynı zamanda bu ifade, değişkene atanır.
            */
            string variableG = null;
            string variableStateG = variableG ??= "helloWorld";
            Console.WriteLine("Null Coalescing Assignment: " + variableStateG);
            Console.WriteLine(variableG);
            #endregion
        }
    }
}
