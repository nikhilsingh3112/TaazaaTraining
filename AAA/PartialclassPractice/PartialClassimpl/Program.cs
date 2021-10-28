using System;
using PartialClassimpl.PartialClassImpl;

namespace PartialClassimpl
{
    class Program
    {
        public static void Main()
        {
           Person person=new Person(101);
           int a= person.getId();
           Console.WriteLine(a);
        }
    }
}
