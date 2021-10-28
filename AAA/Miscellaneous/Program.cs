using System;
using Miscellaneous.IT;

namespace Miscellaneous
{
    class Program
    {
        static void Main()
        {
            var Mohan =new Taazaa(101,1000);
            var Sachin =new Taazaa(102,2000);

            var Sal= Mohan.EmployeeSalary();
            Console.WriteLine(Sal);

            var Sal1= Sachin.EmployeeSalary();
            Console.WriteLine(Sal1);

            var caf= Taazaa.CoffeeHouse();
            Console.WriteLine(caf);

            Console.WriteLine(Taazaa.CoffeeHouse());
        }
    }
}
