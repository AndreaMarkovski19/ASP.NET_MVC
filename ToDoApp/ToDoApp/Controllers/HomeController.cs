using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{    
    public class HomeController : Controller
    {
        public IActionResult NotDone()
        {
            ViewData["Message"] = "Page - Tasks not done.";
            return View();
        }

        public IActionResult InProgress()
        {
            ViewData["Message"] = "Page - Tasks in progress.";
            return View();
        }

        public IActionResult Done()
        {
            ViewData["Message"] = "Page - Tasks done.";

            return View();
        }
    }
}