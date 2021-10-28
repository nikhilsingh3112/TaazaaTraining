using System;

namespace Practece_Indexer
{
    class Student
    {
        private object[] admission=new object[5];
        public object this[int i]
        {
            get
            {
                return admission[i];
            }
            set
            {
                admission[i]=value;
            }

        }
    }
    class Program
    {
        static void Main()
        {
            Student student=new Student();
            student[0]=102;
            student[1]="ganesh";
            System.Console.WriteLine(student[0]+" "+ student[1]);
        }
    }
}
