using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HMS.Models;
using HMS.ViewModels;
using AutoMapper;

namespace HMS.Controllers.API
{
    [RoutePrefix("api/patients")]
    public class PatientsController : ApiController
    {
        private ApplicationDbContext db = null;

        public PatientsController()
        {
            db = new ApplicationDbContext();
        }

        // GET api/<controller>
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var patients = db.Patients
                .Take(10)
                .ToList();
            return Ok(patients);
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            PatientFormViewModel vm = null;
            var patient = db.Patients.SingleOrDefault(p => p.Id == id);

            if (patient == null)
            {
                //return NotFound();
                vm = new PatientFormViewModel
                {
                    Id = 0,
                    Firstname = "",
                    Lastname ="",
                    Gender = ""
                };
            }
            else
            {
                vm = new PatientFormViewModel();
                Mapper.Map<Patient, PatientFormViewModel>(patient, vm);
            }

            return Ok(vm);
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{name}")]
        public IHttpActionResult Get(string name)
        {

            var patients = db.Patients.Where(p => p.Firstname.Contains(name)).ToList();

            if (patients == null)
                return NotFound();

            return Ok(patients);
        }

        // GET api/<controller>/5
        //[HttpGet]
        //public IHttpActionResult Get(int id)
        //{

        //    var patient = db.Patients.Single(p => p.Id == id);

        //    if (patient == null)
        //        return NotFound();

        //    return Ok(patient);
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}