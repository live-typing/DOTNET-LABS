
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public interface iEmpContract
    {
        int WorkHoursClause();
        string SickLeavesClause();

    }
    public class KpmgEmployee : iEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employee is allowed to take at the most 5 sick leaves per month ";
        }

        public int WorkHoursClause()
        {
            return 8;
        }
    }
    public class DellEmployee : iEmpContract
    {


        public string SickLeavesClause()
        {
            return "Employee is allowed to take at the most 30 paid sick leaves per year. ";
        }

        public int WorkHoursClause()
        {
            return 7;
        }
    }
    class MyClass : ParentClass, iContract1, iContract2
    {
        //MyClass can inherit only from 1 other class. It cannot inherit from multiple classes
        //But, it can implement multiple interfaces
        //It can also inherit from 1 class and implement multiple interfaces
    }

    internal interface iContract2
    {
    }

    internal interface iContract1
    {
    }

    internal class ParentClass
    {
    }
}