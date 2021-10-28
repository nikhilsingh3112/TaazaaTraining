using System;
using AdvanceDelegate.Arithmetic;
delegate void ArithmeticDelegate(double D1, double D2);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main()
        {
           ArithmeticDelegate Obj= new ArithmeticDelegate(ArithmeticOperation.Addition);
           //Obj.Invoke(5,4);  // invoke function will addition function  
           Obj+=ArithmeticOperation.Multiply;
           Obj.Invoke(2,3);
        
        }

    }
}
