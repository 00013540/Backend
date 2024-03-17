using WebApplication1.Models;
using WebApplication1.Models.Create;

namespace WebApplication1.Interfaces
{
    public interface ITasksRepository_00013540
    {
        // Create
        Task<CreateUserTask_00013540> AddTaskAsync(CreateUserTask_00013540 task);

        // Get task by id.
        Task<UserTask_00013540> GetTaskByIdAsync(int id);

        // Get all tasks.
        Task<UserTask_00013540[]> GetAllTasksAsync();

        // Update
        Task<UserTask_00013540> UpdateTaskAsync(UserTask_00013540 task);

        Task<bool> DeleteTaskAsync(int id);
    }
}