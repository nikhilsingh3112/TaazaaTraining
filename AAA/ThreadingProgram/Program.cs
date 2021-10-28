using System;
using System.Threading;
namespace ThreadingProgram
{
    public class Mywork
    {
        public void Work1()
        {
            Thread.Sleep(7000);// this function will take 7 sec to perform the task
            System.Console.WriteLine("I m doing for work 1");

        }

        public void Work2()
        {
            System.Console.WriteLine("I am doing for work2");

        }
        public static void Main()// Main is a thread. Thread means it provides the execution to program.or we can say thread is a execution model of the program.
        {
            Mywork mywork=new Mywork();
            mywork.Work1();//at this point we are invoking the first function  called work1
            mywork.Work2();//at this point we are invoking the second function called work2
        }
        
    }
}
