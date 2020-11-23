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

        public IActionResult Index()
        {
            //создание объекта базы данных
            using (SPPLR2Context context = new SPPLR2Context())
            {
                //создание объекта юзеров
                var users = context.Users;

                
                List<Users> Us = new List<Users>();

                //запись всех юзеров в лист
                foreach (var  u in users)
                {
                    Us.Add(u);
                }

                ViewBag.data = Us;

                //вызов страницы idex.html
                return View();
            }
        
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
