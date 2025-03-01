
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

        //public IEnumerable<Task> GetTasksWithDetails()
        //{
            //return _context.Tasks.Include(t => t.Category).ToList();
        //}

        public List<Task> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public IEnumerable<Task> GetTasksWithDetails()
        {
            return _context.Tasks.Include(t => t.Category).ToList();
        }

    }
}
