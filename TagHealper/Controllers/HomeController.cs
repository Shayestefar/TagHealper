using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.ExpressionTranslators.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHealper.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> users = new List<string>
        {
            "Ali",
            "Reza",
            "Rohallah",
            "Meran",
            "Zahra",
            "Ehsan",
            "Mahdi"
        };
            return View(users);
        }
    }
}
