using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment_Basic.Controllers
{
    public class DoctorController : Controller
    {
        private static string message = "";
        private static bool reset = true;

        public IActionResult Index()
        {
            if(reset)
            {
                message = "";
            }

            ViewData["Message"] = message;
            reset = true;

            return View();
        }

        public IActionResult CheckMyFever(int temp)
        {
            message = "";
            

            if(temp != 0)
            {
                message = FeverCheck.CheckForFever(temp);
                reset = false;
            }
            else
            {
                reset = true;
            }

            return RedirectToAction("Index");
        }
    }
}
