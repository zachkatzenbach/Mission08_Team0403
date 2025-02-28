
namespace Mission08_Team0403.Models
{
    public class EFTaskRespository : ITaskRepository
    {
        private TaskDbContext _context;

        public EFTaskRespository(TaskDbContext temp)
        {
            _context = temp;
        }

        public List<Task> Tasks => _context.Tasks.ToList();

    }
}
