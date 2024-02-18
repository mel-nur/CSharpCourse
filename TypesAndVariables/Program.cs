using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 10.4;
            decimal number6 = 10m; //Büyük m harif de olabilir
            var number7 = 10;

            string city = "Ankara";
            char character = 'A';
            bool condition = false;  

            Console.WriteLine("Number1 is : " + number1 );
            Console.WriteLine("Number2 is : " + number2 );
            Console.WriteLine("Number3 is : " + number3 );
            Console.WriteLine("Number4 is : " + number4 );
            Console.WriteLine("Number5 is : " + number5 );
            Console.WriteLine("Number6 is : " + number6 );
            Console.WriteLine("Number7 is : " + number7);
            Console.WriteLine("Character is : " + character );
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday , Tuesday , Wednesday , Thursday , Friday , Saturday , Sunday
    }
}
