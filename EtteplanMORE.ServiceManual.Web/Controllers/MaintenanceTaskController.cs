using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    public class MaintenanceTaskController : Controller
    {
        private readonly IFactoryDeviceService _factoryDeviceService;
        private readonly IMaintenanceTasksService _maintenanceTasksService;

        public MaintenanceTaskController(IFactoryDeviceService factoryDeviceService, IMaintenanceTasksService maintenanceTasksService)
        {
            _factoryDeviceService = factoryDeviceService;
            _maintenanceTasksService = maintenanceTasksService;
        }
        //REST api
        // GET V
        // Post - CreateTask Progress
        // Put - UpdateTask Progress
        // Delete V

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = _maintenanceTasksService.Get(id);

            if (task == null)
            {
                return NotFound("No maitenance found against this id.");
            }
            else
            {
                return Ok(task);
            }
        }


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
            }
            return Ok("Maitenance task has been deleted");
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] MaintenanceTask task)
        {
            if (task.id == null)
            {
                return BadRequest("Enter a valid id");
            }

            _maintenanceTasksService.AddTask(task);

            return CreatedAtRoute("GetTask", new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] MaintenanceTasks task)
        {
            var existingTask = _maintenanceTasksService.Get(id);
            if (existingTask == null)
            {
                return NotFound();
            }
            if (task == null)
            {
                return BadRequest();
            }

            //This needs to go to MTServices
            existingTask.DiscriptionTask = task.DiscriptionTask;
            existingTask.SeverityTask = task.SeverityTask;
            existingTask.StatusTask = task.StatusTask;

            _maintenanceTasksService.UpdateTask(existingTask);

            return Ok(existingTask);

        }
    }
}
