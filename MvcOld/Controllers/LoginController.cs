﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [Route("/login")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [Route("/onLogin")]
        [HttpGet]
        public ActionResult onLogin(string username, string password)
        {
            if (username == "admin" && password == "nimda")
            {
                ViewBag.status = "Login Successful!!";
            }
            return View("Index");
        }
    }
}


