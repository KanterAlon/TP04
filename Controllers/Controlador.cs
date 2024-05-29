using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<int, string> Diccionario = new Dictionary<int, string>();
            ViewBag.Diccionario = Diccionario;
            return View();
        }
    }

}