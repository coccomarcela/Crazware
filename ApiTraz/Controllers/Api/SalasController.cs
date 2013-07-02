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
        public IEnumerable<SalasExtraccion> GetSalasExtracción()
        {
            var SalasExtraccion = db.SalasExtraccion.Include("Grupos").Include("Loc").Include("TiposSalas");
            return SalasExtraccion.AsEnumerable();
        }

        // GET api/Salas/5
        public SalasExtraccion GetSalasExtracción(int id)
        {
            SalasExtraccion SalasExtraccion = db.SalasExtraccion.Single(s => s.NroSalaExtraccion == id);
            if (SalasExtraccion == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return SalasExtraccion;
        }

        // PUT api/Salas/5
        public HttpResponseMessage PutSalasExtracción(int id, SalasExtraccion SalasExtraccion)
        {
            if (ModelState.IsValid && id == SalasExtraccion.NroSalaExtraccion)
            {
                db.SalasExtraccion.Attach(SalasExtraccion);
                db.ObjectStateManager.ChangeObjectState(SalasExtraccion, EntityState.Modified);

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
        public HttpResponseMessage PostSalasExtracción(SalasExtraccion SalasExtraccion)
        {
            if (ModelState.IsValid)
            {
                db.SalasExtraccion.AddObject(SalasExtraccion);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, SalasExtraccion);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = SalasExtraccion.NroSalaExtraccion }));
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
            SalasExtraccion SalasExtraccion = db.SalasExtraccion.Single(s => s.NroSalaExtraccion == id);
            if (SalasExtraccion == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.SalasExtraccion.DeleteObject(SalasExtraccion);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, SalasExtraccion);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}