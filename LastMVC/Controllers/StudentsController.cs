using firstMVC;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace onlyfirstMVC.Controllers
{
    public class StudentsController : Controller
    {
        public StudentsController(AppDbContext db)
        {
            _db = db;
        }
        public AppDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Student> studlist = _db.Students;
            return View(studlist);
        }
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Student item)
        {
            if (item.name == "sad")
            {
                ModelState.AddModelError("customerror", "Name can't be ads");
            }
            if (ModelState.IsValid)
            {
                _db.Students.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }
        }
        public IActionResult Update(int? Id)
        {
            var item = _db.Students.Find(Id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Student item)
        {
            if (item.name == "sad")
            {
                ModelState.AddModelError("customerror", "Name can't be ads");
            }
            if (ModelState.IsValid)
            {
                _db.Students.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }

        }
        public IActionResult Delete(int? Id)
        {
            var item = _db.Students.Find(Id);
            _db.Students.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
