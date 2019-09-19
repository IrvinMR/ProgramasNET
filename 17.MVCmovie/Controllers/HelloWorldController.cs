using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
            //return "Esta es mi accion por default...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        // GET: /HelloWorld/Welcome/ 
// Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
           // return ($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}