using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mission08_Team0403.Models;

namespace Mission08_Team0403.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddTask(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                _taskRepository.AddTask(task);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(_categoryRepository.GetCategories(), "CategoryId", "CategoryName");
            return View(task);
        }

    }
}
