using System;
namespace abstract_class.Abstract
{
    public abstract class Humanbehaviour
    {
        public void Asset()
        {
            Console.WriteLine("has given everything");
        }

        public abstract void job();


    }
    public class Person:Humanbehaviour
    {
        public override void job()
        {
          Console.WriteLine("yes i got a job");  
        }
        public static void Main()
        {
            var obj= new Person();
            obj.Asset();
            obj.job();
        }
    } 
}