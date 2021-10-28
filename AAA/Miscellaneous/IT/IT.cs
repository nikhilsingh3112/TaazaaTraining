namespace Miscellaneous.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int EmpId;
        static string Cafetaria;

        public Taazaa(int eid,double sal)
        {
            Salary=sal;
            EmpId=eid;
        }

        static Taazaa()
        {
            Cafetaria="100 Sqft";
        }
        public int Employeeid()   // member function
        {
            return EmpId;
        }

        public static string CoffeeHouse()  // static function
        {
            return Cafetaria;
        }

        public double EmployeeSalary()  // member function
        {
            return Salary;
        }        
    }

}