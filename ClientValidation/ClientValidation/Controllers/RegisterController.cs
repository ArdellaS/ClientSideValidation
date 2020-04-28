using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientValidation.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User p)
        {
            //validate serverside(back-end)
            //can use data anotation in the model class
            //put info into database

            return View("RegisterSuccess", p);
        }
    }
}