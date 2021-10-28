using System;
using System.Collections.Generic;
namespace switchExample
{
    class Program
    { 
        public static void Main()
        {
        List<string> obj=new List<string>();
        for(int i=0;i<3;i++)
        {
           switch(i)
           {
               case 1:
               obj.Add("Ganesh");
               obj.Add("Pandey");
               System.Console.WriteLine("Name added");
               break;
               case 2:
               if(obj.Contains("Ganesh"))
               {
               Console.WriteLine("Found");
               }
               else
               {
               Console.WriteLine("Not Found");
               }
               break;
           }
        }
       
        }
    }
}