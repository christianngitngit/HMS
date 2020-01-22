using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HMS.Models;
using HMS.ViewModels;
using System.Data.Entity;
using HMS.App_Start;
using AutoMapper;


namespace HMS.Controllers.API
{
    //[RoutePrefix("api/rooms")]
    public class RoomsController : ApiController
    {
        public ApplicationDbContext db = null;

        public RoomsController()
        {
            db = new ApplicationDbContext();
        }

        [HttpGet]
        //[Route("")]
        public IHttpActionResult GetAll(int? limit = null, int? pageSkip = null)
        {
            var rooms = db.Rooms
                .Include(rt => rt.RoomType)
                .Include(os => os.OccupancyStatus);
                

            //if (pageSkip != null)
            //{
            //    rooms.OrderBy(r => r.RoomNo).Skip(pageSkip);            
            //}

            return Ok(rooms.ToList());
        }

        [HttpGet]
        //[Route("{id}")]
        public IHttpActionResult GetRoom(int id)
        {
            RoomFormViewModel roomVM = null;

            var room = db.Rooms.SingleOrDefault(r => r.Id == id);

            if (room == null)
            {
                roomVM = new RoomFormViewModel();
            }
            else
            {
                roomVM = new RoomFormViewModel(room);
            }

            var occupancy = db.OccupancyStatus.ToList();
            var roomType = db.RoomTypes.ToList();

            roomVM.OccupancyStatus = occupancy;
            roomVM.RoomTypes = roomType;

            return Ok(roomVM);
        }

        //[HttpGet]
        //[Route("api/rooms/options")]
        //public IHttpActionResult GetOptions()
        //{
        //    var dbSpecializations = db.Specializations.ToList();
        //    var dbRoomType = db.RoomTypes.ToList();

        //    //var options = { dbSpecializations, dbRoomType };
        //    return Ok();
        //}

        [HttpPost]
        //[Route("api/rooms")]
        public IHttpActionResult Create(RoomFormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var room = Mapper.Map<RoomFormViewModel, Room>(vm);
            db.Rooms.Add(room);
            db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        //[Route("api/rooms")]
        public IHttpActionResult Update(RoomFormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var roomQuery = db.Rooms.Single(r => r.Id == vm.Id);

            if (roomQuery == null)
            {
                return NotFound();
            }

            Mapper.Map(vm, roomQuery);

            db.SaveChanges();

            return Ok();
        }
    }
}
