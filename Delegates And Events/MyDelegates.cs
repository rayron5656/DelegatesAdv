using System.Collections.Generic;

namespace Delegates_And_Events
{
    public delegate void MyDelegate(); 

    public delegate int MyADD(int x,int y);

    public delegate bool FilterDelegate(Student S,object Filterer);

    public delegate void GreetDelegate(string A);

    public delegate bool ContainsDelegate(Student s);

    public delegate float SumDelegate(Student S);

    public delegate float AverageDelegate(Student S);

}