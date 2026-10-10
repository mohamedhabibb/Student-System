using firstMVC;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace onlyfirstMVC.Controllers
{
    public class TeachersController : Controller
    {
        public TeachersController(AppDbContext db)
        {
            _db = db;
        }
        public AppDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Teacher> teaclist = _db.Teachers;
            return View(teaclist);
        }
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Teacher item)
        {
            if (item.Name == "ads")
            {
                ModelState.AddModelError("customerror", "Name can't be ads");
            }
            if(ModelState.IsValid)
            {
                _db.Teachers.Add(item);
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
            var item = _db.Teachers.Find(Id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Teacher item)
        {
            if (item.Name == "ads")
            {
                ModelState.AddModelError("customerror", "Name can't be ads");
            }
            if (ModelState.IsValid)
            {
                _db.Teachers.Update(item);
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
            var item = _db.Teachers.Find(Id);
            _db.Teachers.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
