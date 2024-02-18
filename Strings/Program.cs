using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Melike Nur Çotak ";

            // sentence değişkeninin uzunluğunu Length sayesinde result1 değişkenine atadık. Çıktısı 28
            var result1 = sentence.Length;
            Console.WriteLine(result1);

            // sentence değişkenini result2 değişkenine Clone sayesinde kopyaladık
            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            // EndsWith , değişkenin hangi karakterle bittiğini true ya da false döndürür. sentence değişkeninin sonunun boşluk karakteriyle bitip bitmediğini sorguladık.
            bool result3 = sentence.EndsWith(" ");
            Console.WriteLine(result3);

            // StartsWith , değişkenin hangi karakterle başladğını true ya da false döndürür. sentence değişkeninin başının "My name" karakteriyle bitip bitmediğini sorguladık.
            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            //IndexOf sayesinde içerine yazdığımız karakterin , kaçıncı karakterde olduğunu (başladğını) bulmamızı sağlar. Eğer bulamazsa -1 değerini döndürür.
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" "); //Boşluk karakterinin kaçıncı karakter olduğunu bulur.
            var result7 = sentence.LastIndexOf(" ");//Sondan boşluk karakterini aramaya başlar , kaçıncı karakter olduğunu bulur.
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);

            //Insert istediğimiz indexe istediğimiz ifadeyi eklemizi sağlar. Çıktısı Hello , My name is Melike Nur Çotak
            var result8 = sentence.Insert(0 , "Hello , ");
            Console.WriteLine(result8);
            
            // Substring içine yazılan indextten sonrasını alır
            var result9 = sentence.Substring(3,4);
            Console.WriteLine(result9);

            //ToLower bütün karakterleri küçük yapar
            var result10 = sentence.ToLower();
            Console.WriteLine(result10);

            //ToUpper bütün karakterleri büyük yapar
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            //Replace istediğimiz karakterleri istediğimiz karaktere dönüştürmemizi sağlar.
            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine(result12);

            //Remove içine yazılan indextten sonraki karakterleri siler
            var result13 = sentence.Remove(3);
            Console.WriteLine(result13);

            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(result);
        }
    }
}
