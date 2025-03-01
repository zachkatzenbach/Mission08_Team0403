using AspNetCoreGeneratedDocument;

namespace Mission08_Team0403.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        List<Category> Categories { get; }

        public IEnumerable<Task> GetTasksWithDetails();

        public void AddTask(Task task);

        public void UpdateTask(Task task);

        public Task GetTaskById(int id);
        public void DeleteTask(Task task);

        public void UpdateComplete(Task task);
    }
}
