using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4_flow_controls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch + when/goto
            /*
            Switch ile sadece mevcut degerin, esitlik durumuna gore, 
            ilgili case scope'indaki kodlar yurutulur.
            */
            char charVariables = 'w';
            switch (charVariables)
            {
                case 'x':
                    Console.WriteLine("karakter x ");
                    break;
                case 'y':
                    Console.WriteLine("karakter y ");
                    break;
                case 'z' when (1 > 0):
                    //when keyword eklenerek, switch'e kosul eklenebilir.
                    Console.WriteLine("karakter z ");
                    break;
                case 'w':
                    //goto ile dallanma yapilabilir.
                    goto case 'x';
                default:
                    Console.WriteLine("hic eslesme yoktur");
                    break;
            }
            #endregion

            #region if-else
            string logicalValue = " false";

            if (logicalValue == "true")
            {
                Console.WriteLine(" positive=" + logicalValue);
            }
            else if (logicalValue == "false")
            {
                Console.WriteLine(" negative=" + logicalValue);
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region Pattern Matching

            #region Type Pattern

            object x = "500";
            if(x is int varX)
            {   //x int ise, varX=x olur.
                Console.WriteLine($"x degiskeni int tipindedir.");
            }else if (x is string varY)
            {
                //x str ise, varY=x olur.   
                Console.WriteLine($"x degiskeni bir string'tir.");
            }
           

            #endregion

            #region Constant Pattern
            /* Elimizdeki veriyi sabit ile kiyaslayabiliriz. 
             */

            int varZ = 431;
            Console.WriteLine(varZ is 431);//true yazar.

            #endregion

            #region Var Pattern
            /* Elimizdeki veriyi var degiskeni ile elde etmemizi 
             * saglamaktadir.
             */
            object varAa = "Lorem ipsum";
            if (varAa is var varBb)
            {
                Console.WriteLine(varBb);

            }
            #endregion

            #endregion
            Console.ReadLine();
        }
    }
}
