using System;
class Taaza{
    string emp_name; //instance variable

    string Assign(string str)
    {
        emp_name=str;
        return emp_name;
    }
    public static void Main()
    {
        Taaza obj=new Taaza();
        string temp=obj.Assign("geetika");
        Console.WriteLine(temp);
    }
}
