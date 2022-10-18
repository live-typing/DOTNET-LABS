using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    //objective: Understanding abstract keyword
    //How:
    //Classes: Shape (abstract),Circle (Normal)
    //Relation: Circle: Shape
    //properties:For Circle class: Radius (float)
    //Functions: For Shape class: Draw() ==> abstract

    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Circle drawn with radius {this.Radius}");
        }
    }
}
