using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class DefaultController : Controller
    {
        public static List<Person> People { get; set; }
        public DefaultController()
        {
            if (People == null)
            {
                People = new List<Person>();
                People.Add(new Person()
                {
                    Id = 1,
                    FirstName = "Jafar",
                    LastName = "Ashrafi",
                    FatherName = "Mohammad",
                    Age = 35,
                    PhoneNumber = "+90123334234"
                });
            }
        }
        public IActionResult Index()
        {
            return View(People);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.Id = People.Max(x => x.Id) + 1;
            People.Add(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = People.Single(x => x.Id == id);
            return View(person);
        }

    }
}
