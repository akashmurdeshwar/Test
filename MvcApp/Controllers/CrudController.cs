using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models.Items;

namespace MvcApp.Controllers
{
    public class CrudController : Controller
    {
        private List<Items> _items;
        public CrudController()
        {
            _items = new List<Items> {
                new() {
                Id = 1,
                Name = "Akash",
                Age = 25,
                Department = "HR"
            },
            new() {
                Id = 2,
                Name = "Rajat",
                Age = 30,
                Department = "IT"
            },
           new() {
                Id = 3,
                Name = "Amar",
                Age = 30,
                Department = "FIN"
            }};
        }
        public IActionResult Index()
        {
            var res = _items;

            return View(res);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id, Name, Age, Department")] Items item)
        {
            item.Name = "wer";
            if (ModelState.IsValid)
            {
                _items.Add(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, [Bind("Id, Name, Age, Department")] Items item)
        {
            if (ModelState.IsValid)
            {
                var existingItem = _items.FirstOrDefault(i => i.Id == id);
                if (existingItem == null)
                {
                    return NotFound();
                }
                existingItem.Name = item.Name;
                existingItem.Age = item.Age;
                existingItem.Department = item.Department;
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            _items.Remove(item);
            return RedirectToAction("Index");
        }
    }
}
