namespace Mission08_Team0403.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        List<Category> Categories { get; }

        public IEnumerable<Task> GetTasksWithDetails();

    }
}
