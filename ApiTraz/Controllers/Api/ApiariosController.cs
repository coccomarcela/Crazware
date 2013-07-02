using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ApiTraz.Models;

namespace ApiTraz.Controllers.Api
{
    public class ApiariosController : ApiController
    {
        private ApitrazEntities db = new ApitrazEntities();

        // GET api/Apiarios jbjkbhjbhjbhj
        //njkbkjbkhbhbhj

        public IEnumerable<Apiarios> GetApiarios()
        {
            var apiarios = db.Apiarios.Include("Loc").Include("Productores");
            return apiarios.AsEnumerable();
        }

        // GET api/Apiarios/5
        public Apiarios GetApiarios(string id)
        {
            Apiarios apiarios = db.Apiarios.Single(a => a.ren == id);
            if (apiarios == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return apiarios;
        }

        // PUT api/Apiarios/5
        public HttpResponseMessage PutApiarios(string id, Apiarios apiarios)
        {
            if (ModelState.IsValid && id == apiarios.ren)
            {
                db.Apiarios.Attach(apiarios);
                db.ObjectStateManager.ChangeObjectState(apiarios, EntityState.Modified);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Apiarios
        public HttpResponseMessage PostApiarios(Apiarios apiarios)
        {
            if (ModelState.IsValid)
            {
                db.Apiarios.AddObject(apiarios);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, apiarios);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = apiarios.ren }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Apiarios/5
        public HttpResponseMessage DeleteApiarios(string id)
        {
            Apiarios apiarios = db.Apiarios.Single(a => a.ren == id);
            if (apiarios == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Apiarios.DeleteObject(apiarios);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, apiarios);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}