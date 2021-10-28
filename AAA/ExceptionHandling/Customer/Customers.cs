using System;
namespace ExceptionHandling.Customer
{
    //Exception Class in C sharp is a base class in Exception handling Which Can handle all the Exceptions.
    //ArithmeticException is a base class of DivideByZeroException thats why base class can handle derive class Exception.
    public class customers
    {
        public void Data(int a , int b)
        {
            try
            {
               int x=a,y=b,z;
               z=x/y; //at this point internally thow will be called 
               System.Console.WriteLine(z);
            }
            catch(DivideByZeroException ex)
            {
              System.Console.WriteLine("yes your exception is handled"); 
            }
            finally
            {
                System.Console.WriteLine("Finally block is executed");
            }
           
        }
    }
}