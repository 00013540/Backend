using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.Create;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTasksController_00013540 : ControllerBase
    {
        private readonly ILogger<UserTasksController_00013540> _logger;
        private readonly ITasksRepository_00013540 _tasksRepository;

        public UserTasksController_00013540(ILogger<UserTasksController_00013540> logger,
                                   ITasksRepository_00013540 tasksRepository)
        {
            _logger = logger;
            _tasksRepository = tasksRepository;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllTasksAsync()
        {
            var tasks = await _tasksRepository.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetTaskByIdAsync(int id)
        {
            var task = await _tasksRepository.GetTaskByIdAsync(id);
            return Ok(task);
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreateTaskAsync([FromBody] CreateUserTask_00013540 newTask)
        {
            return Ok(await _tasksRepository.AddTaskAsync(newTask));
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTaskAsync([FromBody] UserTask_00013540 newTask)
        {
            return Ok(await _tasksRepository.UpdateTaskAsync(newTask));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteTaskAsync(int id)
        {
            return Ok(await _tasksRepository.DeleteTaskAsync(id));
        }
    }
}