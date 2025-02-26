using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mission08_Team0403.Models;

namespace Mission08_Team0403.Controllers
{

//This is a test
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

        [HttpGet]
        public IActionResult AddEditTask(int? id)
        {
            if (id == null)  // Add new task
            {
                ViewBag.Categories = new SelectList(_categoryRepository.GetCategories(), "CategoryId", "CategoryName");
                return View(new TaskModel());
            }

            // Edit existing task
            var task = _taskRepository.GetTaskById(id.Value);
            if (task == null) return NotFound();

            ViewBag.Categories = new SelectList(_categoryRepository.GetCategories(), "CategoryId", "CategoryName", task.CategoryId);
            return View(task);
        }

    }

}
}
