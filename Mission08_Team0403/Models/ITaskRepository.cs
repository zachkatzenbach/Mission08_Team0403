namespace Mission08_Team0403.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }

        public void AddTask(Task manager);
    }
}
