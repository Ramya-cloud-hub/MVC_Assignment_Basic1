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

        [HttpGet]
        public IActionResult Guessing_Game()
        {
            Random rand = new Random();

            HttpContext.Session.SetInt32("Rnd", rand.Next(1, 101));

            return View();
        }

        [HttpPost]
        public IActionResult Guessing_Game(int myGuess)
        {
            int randNumber = (int)HttpContext.Session.GetInt32("Rnd");

            if (myGuess > 100 || myGuess < 1)
            {
                ViewData["Message"] = "Your guess isn't valid, You have to guess number between 1 to 100";
            }
            else if (myGuess == randNumber)
            {

                ViewData["Message"] = "Congratulations your guess is correct!";
                HttpContext.Session.Clear();

                Random rand = new Random();
                HttpContext.Session.SetInt32("Rnd", rand.Next(1, 101));
            }
            else if (myGuess > randNumber)
            {
                ViewData["Message"] = "Your guess is too big!";
            }
            else
            {
                ViewData["Message"] = "You guessed is too small!";
            }

            return View();
        }
    }
}