
using System;
class Taaza{
    static string emp_name; //static  variable

    static string Assign(string str)
    {
        emp_name=str;
        return emp_name;
    }
    public static void Main()
    {
        Taaza obj=new Taaza();
        string temp=Taaza.Assign("geetika");
        Console.WriteLine(temp);
    }
}




