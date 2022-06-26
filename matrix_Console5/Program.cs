using System;

namespace matrix_Console5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, work;
            int age;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();  

            Console.WriteLine("Please enter your surname");
            surname = Console.ReadLine();

            Console.WriteLine("Please enter your work");
            work = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:"+" "+name);
            Console.WriteLine("Surname:"+" "+surname);
            Console.WriteLine("Work:"+" "+work);
            Console.WriteLine("age:"+" "+age);





        }
    }
}
