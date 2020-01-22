using System.Web.Mvc;
using HMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace HMS.Controllers
{
    [AllowAnonymous]
    public class PatientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Patients
        public ActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public ActionResult CreatePatient()
        {
            return View();
        }

        public ActionResult PatientForm(int? Id = null)
        {
            ViewBag.Id = Id ?? 0;
            return View();
        }
    }
}