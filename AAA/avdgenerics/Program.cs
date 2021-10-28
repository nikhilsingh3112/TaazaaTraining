using System;
using System.Collections.Generic;
using avdgenerics.TrainingList;
using avdgenerics.Models;
namespace avdgenerics
{
    class Program
    {
        static void Main()
        {
            var obj1=new TaazaTrainingList();
           List<Details> temp=obj1.TrainingList();
           int n=temp.Count;
           for(int i=0;i<n;i++)
           {
               Console.WriteLine(temp[i].Email +" "+ temp[i].PhoneNumber);
           }


            
        }
    }
}
