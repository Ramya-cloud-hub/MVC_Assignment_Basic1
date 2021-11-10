using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace MVC_Assignment_Basic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ContactInfo me = new ContactInfo();
            me.Name = "Ramya Talagavdi Kalegowda";
            me.PhoneNumber = "0048734678";
            me.Email = "xyz@gmail.com";

            return View(me);
        }
        public IActionResult Projects()
        {
            return View();
        }

    }
}
