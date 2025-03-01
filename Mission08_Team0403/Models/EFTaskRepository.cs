
using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0403.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskDbContext _context;

        public EFTaskRepository(TaskDbContext temp)
        {
            _context = temp;
        }

        public List<Task> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public IEnumerable<Task> GetTasksWithDetails()
        {
            return _context.Tasks.Include(t => t.Category).ToList();
        }

        public void AddTask(Task response)
        {
            _context.Tasks.Add(response);
            _context.SaveChanges();
        }

        public void UpdateTask(Task updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
        }
        public Task GetTaskById(int id)
        {
            var task = _context.Tasks.Single(t => t.TaskId == id);
            return task;
        }

        public void DeleteTask(Task task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }

        public void UpdateComplete(Task task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }
    }
}
