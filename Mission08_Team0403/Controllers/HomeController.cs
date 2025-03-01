using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0403.Models;
using Task = Mission08_Team0403.Models.Task;

namespace Mission08_Team0403.Controllers
{

//This is a test
//See if this works
    public class HomeController : Controller
    {
        private ITaskRepository _repo;
        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tasks = _repo.GetTasksWithDetails();
            return View(tasks);
        }


        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _repo.Categories;

            return View("AddEditTask", new Task());
        }
        [HttpPost]
        public IActionResult AddTask(Task response)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(response);

                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
