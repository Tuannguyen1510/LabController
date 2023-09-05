using Microsoft.AspNetCore.Mvc;

namespace Lession1.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            ViewData["messageVD"] = "Dữ liệu";
            ViewBag.messageVD = "ViewBag";
            TempData["messageVD"] = "TempData";
            return View();
        }
        //
        public IActionResult GetAllProducts()
        {
            return View("Products");
        }
    }
}
