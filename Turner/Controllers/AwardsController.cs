using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Turner.Models;

namespace Turner.Controllers
{
    public class AwardsController : ApiController
    {
        private TitleDbContext db = new TitleDbContext();

        // GET: api/Awards
        public IQueryable<Award> GetAwards()
        {
            return db.Awards;
        }

        // GET: api/Awards/5
        //[ResponseType(typeof(Award))]
        public IQueryable<Award> GetAward(int id)
        {
            IQueryable<Award> awards = db.Awards.Where(o => o.TitleId == id).AsQueryable();
            if (awards == null)
            {
                return null;
            }

            return awards;
        }

        // PUT: api/Awards/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAward(int id, Award award)
        {
           
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: api/Awards
        [ResponseType(typeof(Award))]
        public IHttpActionResult PostAward(Award award)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: api/Awards/5
        [ResponseType(typeof(Award))]
        public IHttpActionResult DeleteAward(int id)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AwardExists(int id)
        {
            return db.Awards.Count(e => e.Id == id) > 0;
        }
    }
}