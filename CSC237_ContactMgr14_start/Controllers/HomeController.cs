using CSC237_ContactMgr14_start.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSC237_ContactMgr14_start.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Contact> data { get; set; }
        public HomeController(IRepository<Contact> rep)
        {
            this.data = rep;
        }

        public IActionResult Index()
        {
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                OrderBy = c => c.Firstname
            };
            var contacts = data.List(options);

            return View(contacts);
        }
    }
}
