using firstMVC;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace onlyfirstMVC.Controllers
{
    public class CoursesController : Controller
    {
        public CoursesController(AppDbContext db) 
        {
            _db = db;

        }
        public AppDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Course> courselist = _db.Courses;
            return View(courselist);
        }
        public IActionResult New()
        {
            return View();
        }
       
    }
}
