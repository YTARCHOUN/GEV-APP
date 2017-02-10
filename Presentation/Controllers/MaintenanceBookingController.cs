using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleMaintenance.Controllers
{
    public class MaintenanceBookingController : Controller
    {

        public MaintenanceBookingController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
