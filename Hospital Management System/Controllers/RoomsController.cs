using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.ViewModels;
using HMS.Models;

namespace HMS.Controllers
{
    [AllowAnonymous]
    public class RoomsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rooms
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RoomForm(int? id = null)
        {
            //RoomFormViewModel roomVM = null;

            //var room = db.Rooms.SingleOrDefault(r => r.Id == id);

            //if (id == null)
            //{
            //    roomVM = new RoomFormViewModel();
            //}
            //else
            //{
            //    roomVM = new RoomFormViewModel(room);            
            //}
            //return View(roomVM);
            if (id == null)
            {
                id = 0;
            }
            ViewBag.Id = id;

            return View();
        }
    }
}