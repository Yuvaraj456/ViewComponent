using Microsoft.AspNetCore.Mvc;
using ViewComponentEx.Models;

namespace ViewComponentEx.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Component")]
        public IActionResult Component() 
        {
            PersonGridModel model = new PersonGridModel()
            {
                GridTitle = "Employees List",
                Persons = new List<Person>()
                    {
                        new Person() { Name = "Yuvaraj", JobTitle="Senier Software Dev"},
                        new Person() {Name = "Moni", JobTitle="Software Analyst"},
                        new Person(){Name = "Dufreen", JobTitle="software Analyst"},
                        new Person(){Name="Mary Thersa", JobTitle="Associate"}

                    }
            };
            return ViewComponent("Grid", new { grid = model });
        }
    }
}
