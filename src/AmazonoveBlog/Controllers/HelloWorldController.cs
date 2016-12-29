using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonoveBlog.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            //return View();
            return View();
        }

        public string Welcome()
        {
            return "This is a welcome action!";
        }

        public string WelcomePeople(string name, string from, int id = 0)
        {
            return HtmlEncoder.Default.Encode($"welcome mr {name} from {from} id {id}.");
        }
    }
}
