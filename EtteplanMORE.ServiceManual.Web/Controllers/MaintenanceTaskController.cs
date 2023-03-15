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
        // Post
        // Update
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


        [HttpDelete("{id")]
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

        [HttpPut]
        public IActionResult Post([FromBody] MaintenanceTask task)
        {
            if (task == null)
            {
                return BadRequest();
            }

            _maintenanceTasksService.Create(task);

            return CreatedAtRoute("GetTask", new { id = task.Id }, task);
        }

        [HttpPost]
        public IActionResult PostTask()
        {

        }
    }
}
