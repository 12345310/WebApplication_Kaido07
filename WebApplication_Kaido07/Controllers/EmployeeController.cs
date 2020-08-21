using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Kaido07.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Kaido07.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmpoyees);
        }

    }
}
