using System;

namespace Person
{
    class Program
    {
        static void ShowPersonName(Person person) 
        {
            Console.WriteLine(person.FirstName + person.LastName);
        }
        static void Main(string[] args)
        {
            Woman woman = new Woman();
            woman.FirstName = "Irina";
            woman.LastName = "Ivanova";  
            Man man = new Man();
            man.FirstName = "Ivan";
            man.LastName = "Ivanov";
            Person  woman2 = new Woman();
            woman.Cry();
            man.GoToGym();
            ShowPersonName(woman);
            ShowPersonName(man);
            Console.ReadLine();
        }
    }
}
