using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.Create;

namespace WebApplication1.Repositories
{
    public class TasksRepository_00013540 : ITasksRepository_00013540
    {
        private readonly AppDbContext_00013540 _dbContext;
        private readonly IMapper _mapper;

        public TasksRepository_00013540(AppDbContext_00013540 dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CreateUserTask_00013540> AddTaskAsync(CreateUserTask_00013540 task)
        {
            var taskDb = _mapper.Map<UserTask_00013540>(task);
            _dbContext.UserTasks.Add(taskDb);
            await _dbContext.SaveChangesAsync();

            return task;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _dbContext.UserTasks.FirstOrDefaultAsync(t => t.Id == id);
            if (task == null)
            {
                return false;
            }

            _dbContext.UserTasks.Remove(task);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<UserTask_00013540[]> GetAllTasksAsync()
        {
            return await _dbContext.UserTasks.ToArrayAsync();
        }

        public async Task<UserTask_00013540> GetTaskByIdAsync(int id)
        {
            return await _dbContext.UserTasks.FirstOrDefaultAsync(task => task.Id == id);
        }

        public async Task<UserTask_00013540> UpdateTaskAsync(UserTask_00013540 task)
        {
            var newTaskDb = _mapper.Map<UserTask_00013540>(task);
            _dbContext.UserTasks.Update(newTaskDb);
            await _dbContext.SaveChangesAsync();

            return task;
        }
    }
}