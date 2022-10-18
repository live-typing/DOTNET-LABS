using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oops;
using System.Collections.Generic;
using System.Linq;

namespace FirstApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        [EnableCors("AllowOrigin")]
        [HttpGet("/Greet")]
        
        public string Greeting(string pName)
        {
            return $"Hello {pName}";
        }
        [HttpGet("/allnames")]
        public List<string> AllNames()
        {
            List<string> names = new List<string>() { "Eena", "Meena", "Deeka" };
            return names;
        }
        [DisableCors]
        [HttpGet("/kpmg/employees")]
        public List<KpmgEmployee> GetAllEmployees()
        {
            List<KpmgEmployee> kpmgEmployees = new List<KpmgEmployee>();
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Abc", Designation = "Analyst" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Qwer", Designation = "AnalystS" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Dfg", Designation = "Doctor" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Ghj", Designation = "Manager" });
            return kpmgEmployees;

        }
        [HttpGet("/employees/search/{pName}")]
        public List<KpmgEmployee> SearchEmployee([FromRoute] string pName)
        {
            List<KpmgEmployee> allEmps = GetAllEmployees();
            return allEmps.Where((emp) => { return emp.Name == pName; }).ToList();
        }
        [HttpGet("/employees/search/{pName}/{pDesignation}")]

        public List<KpmgEmployee> SearchEmployee1()
        {
            List<KpmgEmployee> allEmp = GetAllEmployees();
            return allEmp.Where((emp) => { return emp.Name.Contains("a")&&emp.Designation == "Analyst"; }).ToList();
        }
        [HttpGet("/Iaction")]
        public IActionResult GetusingIAction()
        {
            List<KpmgEmployee> kpmgEmployees = new List<KpmgEmployee>();
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Abc", Designation = "Analyst" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Qwer", Designation = "AnalystS" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Dfg", Designation = "Doctor" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Ghj", Designation = "Manager" });
            return Ok(kpmgEmployees);

        }
    }
}