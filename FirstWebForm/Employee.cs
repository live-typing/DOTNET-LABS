using System;

namespace FirstWebForm
{
    [Serializable()]
    public class Employee
    {
        public Employee()
        {
        }

        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Designation { get; set; }
    }
}