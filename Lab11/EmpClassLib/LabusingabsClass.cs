using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLib
{
    public abstract class project1
    {
        public abstract void Do();
    }
    public class Task : project1
    {
        public string work { get; set; }
        public override void Do()
        {
            Console.WriteLine("No leave");
        }
    }
}
