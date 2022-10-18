// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using Oops;
using System.Data;
using System.Net;
using System.Xml.Schema;
using System.Security.Cryptography;

class program
{
    static void Main(string[] args)
    {
        //Base = new Derived
        Shape sh = new Circle() { Radius = 5 };
        sh.Draw();
        // PrintAndRead();
        // {

        // Console.WriteLine("My name is:");
        //var name = Console.ReadLine();
        //Console.WriteLine("i lives in:");
        // var live = Console.ReadLine();
        //Console.WriteLine("hobbies are:");
        //var hobby = Console.ReadLine();
        //Console.WriteLine("My name is {0}.{0} live in {1}.hobbies are {3}", name, live, hobby);

        //}



    }

    private static void Virtualoverriding()
    {
        // Base class = new DerivedClass()
        Parent Meena = new Child();
        Meena.ChooseCareer();  //With permission overriding
        Meena.NoNightOuts();   //With permission hiding
        Console.WriteLine("---child ch = new Child---");
        Child nxgenChild = new Child();
        nxgenChild.NoNightOuts();   //child'sfunction will be called
    }

    private static void usingmethodoverloading()
    {
        Todo myTodo = new Todo()
        {
            Name = "Coding",
            StartDate = DateTime.Now.AddDays(-15),
            EndDate = DateTime.Now.AddDays(15),
            IsCompleted = false
        };

        myTodo.Create(0);
        myTodo.Name = "Angular Training";
        myTodo.StartDate = DateTime.Now.AddDays(-10);
        myTodo.EndDate = DateTime.Now.AddDays(-4);
        myTodo.IsCompleted = true;

        myTodo.Create(1);
        //view all todos
        myTodo.ViewTodos();
        myTodo.ViewTodos("Coding");
    }

    private static void usinginheritance()
    {
        Rectangle r1 = new Rectangle(20, 5);
        float area = r1.calculateArea();
        Console.WriteLine($"Area of R1 with lengthg" +
            $"{r1.length} and breadth {r1.breadth} is" +
            $"{area}");
        Square sql = new Square(10);
        area = sql.calculateArea();
        Console.WriteLine($"Area of R1 with lengthg" +
            $"{sql.length} and breadth {sql.breadth} is" +
            $"{area}");
    }

    private static void basics()
    {
        usingtypecasting();
        gstcalc();
        usingdatatypestostring();
        UsingArithmeticfunc();
        defaultandnullable("Coding", null);
        defaultandnullable("Training", "Angular", true);
        var empId = 1001;
        Execute("storedProc", "Name: spselectAll");
        Execute("query", "Select * from emp", $"where id= {empId}");
    }

    private static void usingtypecasting()
    {
        var currency = 43892320d;
        var str = "100";
        decimal decurrency = (decimal)currency;//=>Type casting:Two datatypes should have something in common
        int num = Convert.ToInt32(str);//=>Type conversion: convert from one unrelated to another unrelated datatype
    }

    private static void gstcalc()
    {
        Console.WriteLine("Enter the food that you want:");
        var food = Console.ReadLine();
        //Console.WriteLine("Enter the amt:");

        // Console.WriteLine("Enter the gst:");
        double amt = 2000d;
        double gst = 0.18d;
        double Total = amt * gst;
        double Totalamt = amt + Total;
        Console.WriteLine($"THE TOTAL AMT HAS TO PAYED:{Totalamt}");
    }

    private static void usingdatatypestostring()
    {
        var intNum = 100;
        var doubleNum = 100d;
        var floatNum = 100f;
        var decimalNum = 100m;
        Console.WriteLine($"Datatype of intNum is : {intNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of doubleNum is : {intNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of floatNum is : {intNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of decimalNum is : {intNum.GetType().ToString()}");
    }

    private static void UsingArithmeticfunc()
    {
        try
        {
            Calculate(100, 25, "Add");
            Calculate(100, 25, "subtract");
            Calculate(100, 25, "Multiply");
            Calculate(100, 25, "Divide");
            Calculate(100, 25, "Exponent");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"something has gone wrong," + $"please contact support with his error code: {ex:Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void PrintAndRead()
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("This code help is a KOOl FEATURE");
        Console.WriteLine("Enter something:");
        var input = Console.ReadLine();

        //Print the entered value
        Console.WriteLine(input);
        Console.WriteLine("The user value entered is:" + input);
        Console.WriteLine("improvised concat: {0}", input); //.net old version
        Console.WriteLine($"latest concat: {input}"); //.net latest
    }
    static void Calculate(int num1,int num2,string OperationType)

    {
        switch (OperationType)
        {
            case "Add":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                break;
            case "subtract":
                    Console.WriteLine($"The sub of {num1} and {num2} is {num1 - num2}");
                break;
            case "Multiply":
                    Console.WriteLine($"The mul of {num1} and {num2} is {num1 * num2}");
                break;
            case "Divide":
                    Console.WriteLine($"The div of {num1} and {num2} is {num1 % num2}");
                break;
            default:
                throw new Exception("ERR-242");
                
        }
    }
    static void defaultandnullable(string task, string? details,bool isCompleted=false)
    {
        Console.WriteLine(task);
        Console.WriteLine(details);
        Console.WriteLine(isCompleted);
    }
    //Execute(...p1:string[])
    static void Execute(params string[] p1)
    {
        Console.WriteLine("Execution Details: ");
        for(int i= 0; i<p1.Length;i++)
        {
            Console.WriteLine(p1[i]);
        }
    }
}

