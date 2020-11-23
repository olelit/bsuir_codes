using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SPP9.Models;

namespace SPP9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //проверка простое ли число
        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public IActionResult Index()
        {    
                return View();      
        }
        public IActionResult Logged()
        {
            //получение куки
            ViewBag.msg = string.Format("Logged to account {0}" , Request.Cookies["Login_data"]);

            return View("Index");
        }

        //Task1
        public IActionResult Task1()
        {
            return View();
        }

        //Task2
        public IActionResult Task2()
        {
            return View();
        }

        public IActionResult Translate(string Login)
        {
            switch(Login){
                case "Literally":
                    ViewBag.Translated = "Буквально";
                    break;
                case "Dog":
                    ViewBag.Translated = "Собака";
                    break;
                case "Cat":
                    ViewBag.Translated = "Кот";
                    break;
                default:
                    ViewBag.Translated = "Not Found";
                    break;
            }

            return View("Task2");
        }

        public IActionResult Task3()
        {
            ViewBag.USD = "25,6";
            ViewBag.EUR = "29,3";
            return View();
        }

        public IActionResult Task4()
        {
            return View();
        }

        public IActionResult Task5()
        {
            return View();
        }

        public IActionResult CheckNumber(uint Login)
        {
            ViewBag.Result = IsPrimeNumber(Login);
            return View("Task4");
        }

        public IActionResult Encrypt(string Login)
        {
            ViewBag.Result = Login.GetHashCode();
            return View("Task5");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
