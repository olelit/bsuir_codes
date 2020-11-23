using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SPP9.Controllers
{
    //контроллер логина в аккаунт
    public class AccountController : Controller
    {
        //метод установки куки
        public void setCookie(string Key, string Value, int expires)
        {
            CookieOptions cookieOptions = new CookieOptions();

            cookieOptions.Expires = DateTime.Now.AddDays(expires);

            Response.Cookies.Append(Key, Value, cookieOptions);

        }
        //логин в аккаунт
        public ActionResult LoginToAccount(string Login, String Password)
        {
            if (Login != null && Password != null)
            {
                using (Models.SPPLR2Context context = new Models.SPPLR2Context())
                {
                    //поиск аккаунта в базе данных
                    var user = context.Users.FirstOrDefault(r => r.Username == Login && r.Password == Password);

                    if (user != null)
                    {
                        //если аккант найден установка куки с именем юзера
                        setCookie("Login_data", user.Username, 7);

                        //редирект на страницу с информацеей о логине
                        return RedirectToRoute(new { controller = "Home", action = "Logged" });
                    }
                    else
                    {
                        //редирект на окно логина если аккаунт не найден
                        return RedirectToRoute(new { controller = "Home", action = "Task1" });
                    }
                }
            }
            else
            {
                //редирект на страницу логина если не все поля заполнены
                return RedirectToRoute(new { controller = "Home", action = "Task1" });
            }
        }
    }
}
