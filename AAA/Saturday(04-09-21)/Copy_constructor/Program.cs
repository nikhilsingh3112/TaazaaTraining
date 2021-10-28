using System;

namespace Copy_constructor
{
    class Person
    {
        public string resume{get;set;}//instance variable
        public Person(string r) // parameterize constructor
        {
            resume=r;
        }
        public Person() // default constructor
        {

        }
    }
    class Program
    {
        public static void Main()
        {
            Person geetika=new Person("My Resume is prepared");
            Person person=new Person();
            Console.WriteLine(person.resume+" "+geetika.resume);
            person=geetika;
            Console.WriteLine(person.resume);
            person.resume="show 12 years of exp";
            Console.WriteLine(geetika.resume);
        }
    }
}