using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    public class MaintenanceTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
