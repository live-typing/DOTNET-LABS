﻿using firstapi;
using firstapi.Data;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oops;
using System.Linq;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        FirstApiContext context = null;
        public DbController(FirstApiContext ctx)
        {

        }

        [HttpPost("/insert")]
        public IActionResult InsertEmp([FromBody] Emp emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return Created("/insert", emp);
        }
        [HttpGet("/all")]
        public IActionResult GetEmp()
        {
            return Ok(context.Employees.ToList());
        }
    }
}