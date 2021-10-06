using System;
using System.Collections.Generic;

namespace Delegates_And_Events
{

    class Program
    {

        

        static public void Shalom()
        {
            Console.WriteLine("Shalom");
        }

        static public void Print2()
        {
            Console.WriteLine("Another Function With the same delegate");
        }

        static public void Shalom2(string A)
        {
            Console.WriteLine($"Shalom {A}");
        }

        static public void Welcome(string A)
        {
            Console.WriteLine($"Welcome {A}");
        }

        static void Main(string[] args)
        {
            Student s1 = new Student(1, 26, "Ron", "Pat", 100, 20000, 1000);
            Student s2 = new Student(2, 19, "Dor", "Pat", 50, 20000, 5000);
            Student s3 = new Student(3, 33, "dit", "Pat", 66, 20000, 6000);
            Student s4 = new Student(4, 12, "Regev", "Pat", 85, 20000, 10000);
            Student s5 = new Student(1, 25, "Ron", "Pat", 90, 20000, 2000);

            StudentList.Allstudents.Add(s1);
            StudentList.Allstudents.Add(s2);
            StudentList.Allstudents.Add(s3);
            StudentList.Allstudents.Add(s4);
            StudentList.Allstudents.Add(s5);

            MyDelegate Mdg = new MyDelegate(Shalom);
            Mdg();

            MyDelegate Mdg2 = new MyDelegate(Print2);
            Mdg2();
            
            GreetDelegate GrD = new GreetDelegate(Shalom2);
            GrD("Ron");
            GreetDelegate Grd2 = new GreetDelegate(Welcome);
            Grd2("Ron");

            MyDelegate Mdg5 = new MyDelegate(new Student(1, 26, "Ron", "Pat", 100, 20000, 1000).Go);
            Mdg5();

            FilterDelegate FLD = new FilterDelegate(StudentList.Get);
            var list1 = StudentList.Filter(FLD,"Ron");

            ContainsDelegate COD = new ContainsDelegate(StudentList.NameMatchContain);
            ContainsDelegate COD2 = new ContainsDelegate(StudentList.GradeContain);
            bool B = StudentList.Contains(COD);
            bool B2 = StudentList.Contains(COD2);

            SumDelegate SMD = new SumDelegate(StudentList.sumLeftToPay);
            SumDelegate SMD2 = new SumDelegate(StudentList.SumPaid);
            StudentList.Sum(SMD);
            StudentList.Sum(SMD2);


            AverageDelegate AVD = StudentList.AgeAverage;
            AverageDelegate AVD2 = StudentList.GradeAverage;
            Console.WriteLine(StudentList.average(AVD));
            Console.WriteLine(StudentList.average(AVD2));











        }
    }
}
