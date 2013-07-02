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
    public class SalasController : ApiController
    {
        private ApitrazEntities db = new ApitrazEntities();

        // GET api/Salas
        public IEnumerable<SalasExtracción> GetSalasExtracción()
        {
            var salasextracción = db.SalasExtracción.Include("Grupos").Include("Loc").Include("TiposSalas");
            return salasextracción.AsEnumerable();
        }

        // GET api/Salas/5
        public SalasExtracción GetSalasExtracción(int id)
        {
            SalasExtracción salasextracción = db.SalasExtracción.Single(s => s.NroSalaExtraccion == id);
            if (salasextracción == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return salasextracción;
        }

        // PUT api/Salas/5
        public HttpResponseMessage PutSalasExtracción(int id, SalasExtracción salasextracción)
        {
            if (ModelState.IsValid && id == salasextracción.NroSalaExtraccion)
            {
                db.SalasExtracción.Attach(salasextracción);
                db.ObjectStateManager.ChangeObjectState(salasextracción, EntityState.Modified);

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

        // POST api/Salas
        public HttpResponseMessage PostSalasExtracción(SalasExtracción salasextracción)
        {
            if (ModelState.IsValid)
            {
                db.SalasExtracción.AddObject(salasextracción);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, salasextracción);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = salasextracción.NroSalaExtraccion }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Salas/5
        public HttpResponseMessage DeleteSalasExtracción(int id)
        {
            SalasExtracción salasextracción = db.SalasExtracción.Single(s => s.NroSalaExtraccion == id);
            if (salasextracción == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.SalasExtracción.DeleteObject(salasextracción);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, salasextracción);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}