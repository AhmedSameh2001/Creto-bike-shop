using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CretoBikeShop.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}