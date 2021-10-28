using System.ComponentModel.DataAnnotations;
namespace employeeservice.Models
{
    public class Employee
    {
        public int EmployeeCode{get;set;}
        public string EmployeeName{get;set;}
        
        [Range(21,45)]
        public int EmployeeAge{get;set;}
    }
}