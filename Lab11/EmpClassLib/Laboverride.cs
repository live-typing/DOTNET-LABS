using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLib
{
    public class Employer

    {
        public virtual void Project()
        {
            Console.WriteLine("Finish the assigned work");
        }
        public void Holiday()
        {
            Console.WriteLine("improve time management");
        }
    }
    public class Employee1 : Employer
    {
        public override void Project()
        {
            Console.WriteLine("i am already done with my work");
        }
        public void Holiday()
        {
            Console.WriteLine("Then i will take my week off");
        }
    }
}
