using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HMS.Models;

namespace HMS.Controllers.API
{
    [RoutePrefix("api/specializations")]
    public class SpecializationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Specializations
        [HttpGet]
        [Route("")]
        public IQueryable<Specialization> GetSpecializations()
        {
            return db.Specializations;
        }

        // GET: api/Specializations/5
        [ResponseType(typeof(Specialization))]
        public async Task<IHttpActionResult> GetSpecialization(byte id)
        {
            Specialization specialization = await db.Specializations.FindAsync(id);
            if (specialization == null)
            {
                return NotFound();
            }

            return Ok(specialization);
        }

        // PUT: api/Specializations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSpecialization(byte id, Specialization specialization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != specialization.Id)
            {
                return BadRequest();
            }

            db.Entry(specialization).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecializationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Specializations
        [ResponseType(typeof(Specialization))]
        public async Task<IHttpActionResult> PostSpecialization(Specialization specialization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Specializations.Add(specialization);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SpecializationExists(specialization.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = specialization.Id }, specialization);
        }

        // DELETE: api/Specializations/5
        [ResponseType(typeof(Specialization))]
        public async Task<IHttpActionResult> DeleteSpecialization(byte id)
        {
            Specialization specialization = await db.Specializations.FindAsync(id);
            if (specialization == null)
            {
                return NotFound();
            }

            db.Specializations.Remove(specialization);
            await db.SaveChangesAsync();

            return Ok(specialization);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SpecializationExists(byte id)
        {
            return db.Specializations.Count(e => e.Id == id) > 0;
        }
    }
}