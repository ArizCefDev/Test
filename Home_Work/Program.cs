using System;
using System.Collections;
using System.Collections.Generic;

namespace Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Action
            Name(() => { Console.WriteLine("Ariz"); });

            //Func
            
            SurName((x) => { return "Ceferli"; });
            
            //Predicate
            Age((x) => x > 18);

        }

        //Action tipinde metod
        public static void Name(Action action)
        {
            action();
        }

        //Func tipinde metod
        public static void SurName(Func<int,string> func)
        {
            func(1);
        }

        //Predicate tipinde metod

        public static void Age(Predicate<int> predicate)
        {
            predicate(20);
        }
    }
}
