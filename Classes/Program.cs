using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.City = "Ankara";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";

            Customer customer2 = new Customer()
            {
                Id = 2 , City = "Denizli", FirstName = "Melike" , LastName = "Çotak"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
