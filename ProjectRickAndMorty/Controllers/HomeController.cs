using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using ProjectRickAndMorty.Models;
using System.Diagnostics;
using System.Globalization;

namespace ProjectRickAndMorty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            var cultureInfo = new CultureInfo(culture);
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;

            Response.Cookies.Append("Culture", culture, new CookieOptions
            {
                Expires = DateTime.UtcNow.AddYears(1)
            });
            
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
