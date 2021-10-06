using System;

namespace Delegates_And_Events
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int NeedToPay { get; set; }
        public int AmountPaid { get; set; }


        public Student()
        {
        }

        public Student(int id, int age, string firstName, string lastName, int grade, int needToPay, int amountPaid)
        {
            Id = id;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            NeedToPay = needToPay;
            AmountPaid = amountPaid;
        }

        public void Go()
        {
            Console.WriteLine($"MMy name is {FirstName}");
        }
            
    }
}
