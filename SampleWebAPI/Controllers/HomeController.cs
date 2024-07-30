using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Entity;
using System.Threading.Tasks;

namespace SampleWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Random2()
        {
            string name = "Abhi";
            return Ok(new { message = "okok" });
        }
        public async Task<ActionResult> Random23()
        {
            string name = "Abhi";
            return Ok(new { message = "okok" });
        }
        public async Task<ActionResult> Random21()
        {
            string name = "Abhi";
            return Ok(new { message = "okok" });
        }

        public async Task<Person> PersonMethod()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Naman",
                Description = "Student",
                Title = "Mr"
            };
            return Ok(person);
        }
    }
}
