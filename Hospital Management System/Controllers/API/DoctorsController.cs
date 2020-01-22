using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HMS.Models;
using System.Data.Entity;
using System.Web.Http.Cors;

namespace HMS.Controllers.API
{
    //[EnableCors(origins: "http://localhost:8010", headers: "*", methods: "*")]
    //[RoutePrefix("api/doctors")]
    public class DoctorsController : ApiController
    {
        private ApplicationDbContext db = null;

        public DoctorsController()
        {
            db = new ApplicationDbContext();

        }

        // GET: api/Doctors
        //public IHttpActionResult Get()
        //{
        //    var doctors = db.Doctors
        //        .Include(s => s.Specialization)
        //        .ToList();

        //    return Ok(doctors);
        //}

        // GET: api/Doctors
        //[Route("api/doctors/{specializationId}")]
        [HttpGet]
        //[Route("")]
        public IHttpActionResult Get(int? specializationId = null, int? pageSkip = null)
            //public IHttpActionResult Get(string query = null)
        {
            var doctorsQuery = db.Doctors
                .Include(s => s.Specialization)                
                .AsQueryable();

            if (specializationId != null)
            {
                doctorsQuery = doctorsQuery.Where(d => d.SpecializationId == specializationId);           
            }

            if (pageSkip != null)
            {
                int skip = 10 * ((int)pageSkip - 1);
                doctorsQuery = doctorsQuery.OrderBy(d => d.Id).Skip(skip);
            }

            return Ok(doctorsQuery.ToList());
        }

        // GET: api/Doctors/5
        [Route("api/doctors/{id}")]
        public IHttpActionResult Get(int id)
        {
            var doctor = db.Doctors
                .Include(s => s.Specialization)
                .SingleOrDefault(d => d.Id == id);
                

            if (doctor == null)
                return NotFound();

            return Ok(doctor);
        }

        // POST: api/Doctors
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(Doctor doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            db.Doctors.Add(doctor);
            db.SaveChanges();

            return Ok();
        }

        // PUT: api/Doctors/5
        [HttpPut]
        public IHttpActionResult Put(Doctor doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var doctorDb = db.Doctors.Find(doctor.Id);

            if (doctorDb == null)
                return NotFound();

            doctorDb.Firstname = doctor.Firstname;
            doctorDb.Lastname = doctor.Lastname;
            doctorDb.SpecializationId = doctor.SpecializationId;

            db.SaveChanges();

            return Ok();
        }

        // DELETE: api/Doctors/5
        [HttpDelete]
        [Route("api/Doctors/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var doctor = db.Doctors.SingleOrDefault(d => d.Id == id);

            if (doctor == null)
                return NotFound();

            db.Doctors.Remove(doctor);
            db.SaveChanges();

            return Ok();
        }
    }
}
