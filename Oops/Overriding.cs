using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oops
{
    //Objective : Understand overriding
    //Expectation: Need a parent class,child class  and one function called Choosecareer()
    //Classes:Parent,Child
    //Relationship: Child:Parent
    //Properties:None
    //Functions: ChooseCareer() in both the classes

    public class Parent
    {
        public virtual void ChooseCareer()
        {
            Console.WriteLine("Take admission for BE Computer Science");
        }

        public void NoNightOuts()
        {
            Console.WriteLine("Night outs not allowed");
        }
    }
    public class Child : Parent
    {
        public override void ChooseCareer()
        {
            Console.WriteLine("i will choose to become a comedian");
        }
        public void NoNightOut()
        {
            Console.WriteLine("no night out");
        }
    }
    
}
