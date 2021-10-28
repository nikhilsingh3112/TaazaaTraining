namespace Miscellaneous1.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int Empid;

        static string TemptationsCafe;

        public Taazaa(int Eid, double sal)
        {
            Salary=sal;
            Empid=Eid;
        }

        static Taazaa()
            {
                TemptationsCafe= "BBD";
            }

        public int Employeeid()
        {
            return Empid;

        }
        

    }
}