using System.Runtime.CompilerServices;

namespace Oops
{
    public class Rectangle
    {    
        public string Name { get; set; }

        public Rectangle()
        {
            this.Name = "Rectangle";
        }
        public Rectangle(float plength,float pbreadth)
        {
            this.length = plength;
            this.breadth = pbreadth;
        }
        public float length { get; set; }
        public float breadth { get; set; }
        public float calculateArea()
        {
            return length * breadth;
        }
    }
}