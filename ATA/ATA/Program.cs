using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------
            Console.WriteLine("Hi!");

            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);

            Console.WriteLine("ļoti patīkami iepazītes!");

            Console.WriteLine("Kur tu dzīvo?");

            string userName1 = Console.ReadLine();

            Console.WriteLine("Skaidrs!");

            Console.WriteLine("Cik tev ir gadi?");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);

            int previosYearAge = age - 1;

            Console.WriteLine("Sveiks tev ieprekšēja gadā bija:  " + previosYearAge);


            Console.WriteLine("Prieks iepazītes!");

            Console.WriteLine();



            //--------------------------------------

            

            string userName3 = Console.ReadLine();

            int myNumber1 = 15;
            int myNumber2 = 21;

            bool isEgualNumber = myNumber1 == myNumber2;

            Console.WriteLine(isEgualNumber);

            //-----------------------

            int myNumber3 = 15;
            int myNumber4 = 21;

            bool isEgualNumber1 = myNumber3 < myNumber4;

            Console.WriteLine(isEgualNumber);

            ///------------------------------


            int maxNumber1 = 20;
            int maxNumber2 = 41;

            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxResult);

            //------------------------------

            int minNumber3 = 3;
            int minNumber4 = 41;

            int minResult = Math.Max(minNumber3, minNumber4);

            Console.WriteLine(maxResult);

            ///-------------------------------------

            int a = 9;
            int b = 7;
            int c;
            c = a * b / 2;
            Console.WriteLine(c);
            Console.ReadLine();

            //---------------------------

            double numberToRound = 12.456;
            double Rounded = Math.Round(numberToRound, 1);
            Console.WriteLine(Rounded);




        }
    }
}
