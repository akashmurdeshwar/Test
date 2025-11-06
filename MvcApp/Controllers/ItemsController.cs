using Microsoft.AspNetCore.Mvc;
using MvcApp.Models.Items;

namespace MvcApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var items = new Items
            {
                Name = "Sample Item",
                Id=12
            };
            return View(items);
        }

        public IActionResult Edit(int id)
        {
            return Json(new { Message = "Edit item", ItemId = id });
            //return Content($"Edit item with ID: {id}");
        }

        public IActionResult MessageView()
        {
            return View();
        }

        public IActionResult ListView()
        {
            return View();
        }
    }
}
