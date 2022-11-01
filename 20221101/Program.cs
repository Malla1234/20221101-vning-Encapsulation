using System;

namespace _20221101
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            Customer C2 = new Customer();
            Customer C3 = new Customer();
            

            C1.Id = 100;
            C1.FirstName = "Janne";
            C1.LastName = "Johansson";
            C1.Email = "Janne@gmail.com";

            C2.Id = 200;
            C2.FirstName = "Johan";
            C2.LastName = "Eriksson";
            C2.Email = "Johan@gmail.com";

            C3.Id = -10;
            C3.FirstName = "";
            C3.LastName = "";
            C3.Email = "";

            Console.WriteLine($"Info Custumer one:{C1.Id}, {C1.FirstName}, {C1.LastName}, {C1.Email}");
            Console.WriteLine($"Info Custumer two:{C2.Id}, {C2.FirstName}, {C2.LastName}, {C2.Email}");
            Console.WriteLine($"Info Custumer three:{C3.Id}, {C3.FirstName}, {C3.LastName}, {C3.Email}");

        }
    }
}
