using System.Collections.Generic;

namespace Delegates_And_Events
{
    static class StudentList
    {
        static public List<Student> Allstudents = new List<Student>();
        static public List<Student> Searchedstudents;




        static public List<Student> Filter(FilterDelegate FilterMethod,object Filterer)
        {
            List<Student> List = new List<Student>();

            foreach (Student S in Allstudents)
            {
                if (FilterMethod(S, Filterer))
                {
                    List.Add(S);
                }
            }
            return List;
            

        }

        

        static public bool Contains(ContainsDelegate containsDelegate)
        {
            foreach (Student stdnt in Allstudents)
            {
                if (containsDelegate(stdnt))
                {
                    return true;
                }
            }
            return false;
            
        }



        static public bool GradeContain(Student S)
        {
           
                if (S.Grade < 50)
                {
                    return true;
                }
            
            return false;
        }

        static public bool NameMatchContain(Student S)
        {

           
                if (S.FirstName.StartsWith(S.LastName[0]))
                {
                     return true;
                }

            return false;
            
        }


        static public bool Get(Student S,object Filterer)
        {
            

            if (Filterer is string)
            {
                
                    if (S.FirstName == Filterer.ToString())
                    {
                        return true;
                    }
                

                
            }
            if (Filterer is int)
            {
                
                    if (S.Id == int.Parse(Filterer.ToString()))
                    {
                        return true;
                    }
                
                
            }


            return false;



        }

        static public void Sum(SumDelegate sumDelegate)
        {
            float F = 0;


            foreach (Student s in Allstudents)
            {
                F +=  sumDelegate(s);
            }

            System.Console.WriteLine(F);
        }

        static public float SumPaid(Student S)
        {
            return (S.AmountPaid);
        }

        static public float sumLeftToPay(Student S)
        {
            return ((S.NeedToPay - S.AmountPaid));
        }

        static public float average(AverageDelegate averageDelegate)
        {
            float count = 0;
            float sum = 0;

            foreach (Student S in Allstudents)
            {
                sum += averageDelegate(S);
                count++;
            }

            return (sum / count);
        }

        public static float AgeAverage(Student S)
        {
            return S.Age;
        }

        public static float GradeAverage(Student S)
        {
            return S.Grade;
        }

       
    }
}
