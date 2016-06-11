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
    public class TitleParticipantsController : ApiController
    {
        private TitleDbContext db = new TitleDbContext();

        // GET: api/TitleParticipants
        public IQueryable<TitleParticipant> GetTitleParticipants()
        {
            return db.TitleParticipants;
        }

        // GET: api/TitleParticipants/5
        public IQueryable<TitleParticipant> GetTitleParticipant(int id)
        {
            IQueryable<TitleParticipant> participants = db.TitleParticipants.Where(o => o.TitleId == id).AsQueryable();
            if (participants == null)
            {
                return null;
            }

            return participants;
        }

        // PUT: api/TitleParticipants/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTitleParticipant(int id, TitleParticipant titleParticipant)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: api/TitleParticipants
        [ResponseType(typeof(TitleParticipant))]
        public IHttpActionResult PostTitleParticipant(TitleParticipant titleParticipant)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: api/TitleParticipants/5
        [ResponseType(typeof(TitleParticipant))]
        public IHttpActionResult DeleteTitleParticipant(int id)
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

        private bool TitleParticipantExists(int id)
        {
            return db.TitleParticipants.Count(e => e.Id == id) > 0;
        }
    }
}