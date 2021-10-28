using System.Collections.Generic;
using avdgenerics.Models;
namespace avdgenerics.TrainingList
{
    public class TaazaTrainingList
    {
       public List<Details> TrainingList()
       {
         List<Details> obj=new List<Details>();
         obj.Add(new Details{
             Email="ganeshpandey747@gmail.com",
             PhoneNumber=747
         });
         obj.Add(new Details{
             Email="ganesh747@gmail.com",
              PhoneNumber=999
            
         });
           return obj;
       } 
    }
}