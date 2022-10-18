using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //Created a new datatype
    //Viz. Declaration of Delegate


    public delegate void PM(string requirement);
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Reena Chakravarthy");
        names.ForEach((str) => { Console.WriteLine(str); });

        List<string> result = names.Where((str) => { return str == "Reena"; }).ToList();
        Console.WriteLine("Search for 'Reena'");
        result.ForEach((str) => { Console.WriteLine($"Fond match for: {str}"); });

    }

    private static void CallDelegates()
    {
        //Object or Instantiation of Delegate
        PM Vimal = new PM((requirement) => { Console.WriteLine("I, Hari have attended the training "); });
        Vimal += (requirement) => { Console.WriteLine("I, ABC have attended the training "); };
        Vimal += (requirement) => { Console.WriteLine("I, QWERTY have attended the training "); };
        //Calling Vimal
        //Invoking Delegate
        Vimal("Tax Tech Training for The team");
    }

}