using System;
using System.Collections.Generic;
namespace listprac
{
        public class Employee
    {  
        public int Eid{get;set;}
        public string Ename{get;set;}
        
    }
     public class EmployeeList
    {
        List<Employee> list;
         public  EmployeeList()
        {
            list = new List<Employee>();
        }
         public int AddEmployee(Employee employee)
        {
            list.Add(employee);
            return 1;
        }
    }

    class Program
    {
        static void Main()
        {
             Employee obj=new Employee();
             obj.Eid=101;
             obj.Ename="Ganesh";
             
             
             EmployeeList obj1=new EmployeeList();
             var a=obj1.AddEmployee(obj);
             if(a==1)
             {
               System.Console.WriteLine(a);  
             }
             
             
        }
    }
}