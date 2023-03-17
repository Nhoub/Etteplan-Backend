using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using EtteplanMORE.ServiceManual.Web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]

    public class MaintenanceTaskController : Controller
    {
        private readonly IFactoryDeviceService _factoryDeviceService;
        private readonly IMaintenanceTasksService _maintenanceTasksService;

        public IMaintenanceTasksService Object { get; }

        public MaintenanceTaskController(IFactoryDeviceService factoryDeviceService, IMaintenanceTasksService maintenanceTasksService)
        {
            _factoryDeviceService = factoryDeviceService;
            _maintenanceTasksService = maintenanceTasksService;
        }

        /// <summary>
        /// Get the Maintenance task corrospoding with the given Id otherwise give a Not Found warning
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = _maintenanceTasksService.Get(id);

            if (task == null)
            {
                return NotFound("No maitenance task found against this id.");
            }
            else
            {
                return Ok(Task(task));
            }
        }

        /// <summary>
        /// Delete the maitenance task corrosponding with the given Id otherwise give a Not Found warning
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _maintenanceTasksService.Get(id);
            if (task == null)
            {
                return NotFound("No maitenance found against this id.");
            }
            else
            {
                _maintenanceTasksService.DeleteTask(id);
                return Ok("Maitenance task has been deleted");
            }
        }

        /// <summary>
        /// Create a new Maitenance task
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateTask([FromBody] MaintenanceTaskDto task)
        {
            if (ModelState.IsValid)
            {
                var createTask = new MaintenanceTasks()
                {
                    DeviceId = task.DeviceId,
                    DiscriptionTask = task.DescriptionTask,
                    SeverityTask = (SeverityTask)Enum.Parse(typeof(SeverityTask), task.SeverityTask, true),
                    StatusTask = (StatusTask)Enum.Parse(typeof(StatusTask), task.StatusTask, true)
                };

                var newTask = _maintenanceTasksService.AddTask(createTask);

                return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, Task(newTask));
            }
            else
            {
                return BadRequest("One or more values are not correct, try again");
            }
        }


        /// <summary>
        /// Update an existing Maitenance task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] MaintenanceTaskDto task)
        {
            if (id != task.TaskId)
            {
                return BadRequest("Not the correct taskId");
            }
            if (ModelState.IsValid)
            {
                var taskId = _maintenanceTasksService.Get(id);
                var createTask = new MaintenanceTasks()
                {
                    Id = task.TaskId,
                    DeviceId = task.DeviceId,
                    DiscriptionTask = task.DescriptionTask,
                    SeverityTask = (SeverityTask)Enum.Parse(typeof(SeverityTask), task.SeverityTask, true),
                    StatusTask = (StatusTask)Enum.Parse(typeof(StatusTask), task.StatusTask, true)
                };

                var updatedTask = _maintenanceTasksService.UpdateTask(createTask);

                return Ok(Task(updatedTask));
            }
            else
            {
                return BadRequest("One or more values are not correct, try again");
            }
        }

        /// <summary>
        /// Add the given Maitenance task values to the collumn in the database
        /// </summary>
        /// <param name="maintenanceTask"></param>
        /// <returns></returns>
        private MaintenanceTaskDto Task(MaintenanceTasks maintenanceTask)
        {
            return new MaintenanceTaskDto()
            {
                TaskId = maintenanceTask.Id,
                DescriptionTask = maintenanceTask.DiscriptionTask,
                DeviceId = maintenanceTask.DeviceId,
                RegisteredTimeTask = Convert.ToString(maintenanceTask.RegisteredTimeTask),
                SeverityTask = maintenanceTask.SeverityTask.ToString(),
                StatusTask = maintenanceTask.StatusTask.ToString()
            };
        }
    }
}
