using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            var result = Add2(20, 30);
            Console.WriteLine("Sonuç = " + result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine("Sonuç : " + result2);
            Console.WriteLine("Number1 : " + number1);

            int number3;
            int number4 = 100;
            var result3 = Add4(out number3, number4);
            Console.WriteLine("Sonuç : " + result3);
            Console.WriteLine("Number3 : " + number3);


            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(1, 2, 3));

            Console.WriteLine(Add5(1,2,3,4,5,6));

            Console.ReadLine();
        }

        static void Add() 
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1 = 20 , int number2 = 30)
        {
            var result = number1 + number2;
            return result;

        }

        static int Add3(ref int number1 , int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }

        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }

        static int Multiply(int number1 , int number2)
        {
            return number1 * number2;

        }

        // Methodlarda overloading
        static int Multiply(int number1, int number2 , int number3)
        {
            return number1 * number2 * number3;

        }

        // params keyword'ü ile istediğimiz kadar parametre atayabiliriz.
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
