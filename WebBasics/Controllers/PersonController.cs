using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBasics.Models;

namespace WebBasics.Controllers
{
    public class PersonController : Controller
    {
        public static IList<Person> Persons = new List<Person>();

        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
    }
}