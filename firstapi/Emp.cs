using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace firstapi
{
    public class Emp
    {
        [Key]
        public int empID { get; set; }
        public int Name { get; set; }
        public int Designation { get; set; }
        public double Salary { get; set; }
    }
}
