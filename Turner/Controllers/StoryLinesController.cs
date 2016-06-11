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
    public class StoryLinesController : ApiController
    {
        private TitleDbContext db = new TitleDbContext();

        // GET: api/StoryLines
        public IQueryable<StoryLine> GetStoryLines()
        {
            return db.StoryLines;
        }

        // GET: api/StoryLines/5
        //[ResponseType(typeof(StoryLine))]
        public IQueryable<StoryLine> GetStoryLine(int id)
        {
            IQueryable<StoryLine> storyLine = db.StoryLines.Where(o => o.TitleId == id).AsQueryable();
            if (storyLine == null)
            {
                return null;
            }

            return storyLine;
        }

        // PUT: api/StoryLines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStoryLine(int id, StoryLine storyLine)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: api/StoryLines
        [ResponseType(typeof(StoryLine))]
        public IHttpActionResult PostStoryLine(StoryLine storyLine)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: api/StoryLines/5
        [ResponseType(typeof(StoryLine))]
        public IHttpActionResult DeleteStoryLine(int id)
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

        private bool StoryLineExists(int id)
        {
            return db.StoryLines.Count(e => e.Id == id) > 0;
        }
    }
}