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
using System.Web.Http.OData.Query;

namespace ApiTraz.Controllers.Api
{
    public class DepartamentosController : ApiController
    {
        private ApitrazEntities db = new ApitrazEntities();

        // GET api/Departamentos
        [Queryable(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable<Dptos> GetDptosList(ODataQueryOptions queryOptions)
        {           
            // Apply the query
            return queryOptions.ApplyTo(db.Dptos.Include("Loc").AsQueryable()) as IQueryable<Dptos>;
        }

        // GET api/Departamentos/5
        public Dptos GetDptos(int id)
        {
            Dptos dptos = db.Dptos.Single(d => d.CodDpto == id);
            if (dptos == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return dptos;
        }

        // PUT api/Departamentos/5
        public HttpResponseMessage PutDptos(int id, Dptos dptos)
        {
            if (ModelState.IsValid && id == dptos.CodDpto)
            {
                db.Dptos.Attach(dptos);
                db.ObjectStateManager.ChangeObjectState(dptos, EntityState.Modified);

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

        // POST api/Departamentos
        public HttpResponseMessage PostDptos(Dptos dptos)
        {
            if (ModelState.IsValid)
            {
                db.Dptos.AddObject(dptos);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, dptos);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = dptos.CodDpto }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Departamentos/5
        public HttpResponseMessage DeleteDptos(int id)
        {
            Dptos dptos = db.Dptos.Single(d => d.CodDpto == id);
            if (dptos == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Dptos.DeleteObject(dptos);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, dptos);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}