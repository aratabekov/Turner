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
    public class TitlesController : ApiController
    {
        private TitleDbContext db = new TitleDbContext();

        // GET: api/Titles
        public IQueryable<Title> GetTitles()
        {
            return db.Titles;
        }

        // GET: api/Titles/5
        [ResponseType(typeof(Title))]
        public IHttpActionResult GetTitle(int id)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return NotFound();
            }

            return Ok(title);
        }

        // PUT: api/Titles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTitle(int id, Title title)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: api/Titles
        [ResponseType(typeof(Title))]
        public IHttpActionResult PostTitle(Title title)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: api/Titles/5
        [ResponseType(typeof(Title))]
        public IHttpActionResult DeleteTitle(int id)
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

        private bool TitleExists(int id)
        {
            return db.Titles.Count(e => e.TitleId == id) > 0;
        }
    }
}