using BusinessLayer;
using System.Web.Mvc;

namespace MVC_app.Controllers
{
    public class PersonController : Controller
    {
        public PersonController()
        {
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            var person = new Person
            {
                FirstName = formCollection["FirstName"],
                LastName = formCollection["LastName"],
                City = formCollection["City"],
                State = formCollection["State"],
                Gender = formCollection["Gender"]
            };
            PersonService.GetInstance.Persons.Add(person);
            return RedirectToAction("List");
        }


        public ActionResult List()
        {
            return View(PersonService.GetInstance.Persons);
        }
    }
}