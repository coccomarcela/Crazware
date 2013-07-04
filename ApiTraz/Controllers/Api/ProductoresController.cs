

using System.Web.Http.OData;
using ApiTraz.Models;
using System.Web.Http;
using System.Web.Http.OData.Query;
using System.Net.Http;
using System.Linq;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Net;
using System;
using System.Collections.Generic;


namespace ApiTraz.Controllers
{
    public class ProductoresController : ApiController //EntitySetController<Productores, string> //ApiController
    {
        private  ApitrazEntities db= new ApitrazEntities();
       
        // GET api/ApiProductores
        
        [Queryable(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable<Productores> GetProductoresList(ODataQueryOptions queryOptions)
        {
         
            // Apply the query
            return queryOptions.ApplyTo(db.Productores.AsQueryable()) as IQueryable<Productores>;
          
          
        }


      //protected override Productores GetEntityByKey(string id)

      //{
      //    Productores productores = db.Productores.Single(p => p.ren == id);
      //    if (productores == null)
      //    {
      //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
      //    }

      //    return productores;
      //}
      //protected override Productores PatchEntity(string key, Delta<Productores> patch)
      //{
      //    Productores productores = db.Productores.Single(p => p.ren == key);
      //    if (productores == null)
      //    {
      //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
      //    }

      //    patch.Patch(productores);
      //    db.SaveChanges();
      //    return productores;
        
      //}

        ////public PageResult<ProductViewModel> Get(ODataQueryOptions QueryOptions)
        ////{
        ////    ApitrazEntities model = new ApitrazEntities();
        ////    ODataQueryContext queryContext = new ODataQueryContext(db, typeof(Productores));
        ////    var mappedQuery = new ODataQueryOptions(queryContext, QueryOptions.Request);
        ////    var results = new List<ProductViewModel>();

        ////    foreach (var result in mappedQuery.ApplyTo(this.context.Serials.Include("Status").Include("Category")))
        ////    {
        ////        AutoMapper.Mapper.CreateMap(result.GetType(), typeof(ProductViewModel));
        ////        results.Add(AutoMapper.Mapper.Map<ProductViewModel>(result));
        ////    }

        ////    PageResult<ProductViewModel> pr = new PageResult<ProductViewModel>(results.AsEnumerable<ProductViewModel>(), mappedQuery.Request.GetNextPageLink(), mappedQuery.Request.GetInlineCount());
        ////    return pr;
        ////}



        //// GET api/ApiProductores/5
        //public Productores GetProductoresByID(string id)
        //{
        //    Productores productores = db.Productores.Single(p => p.ren == id);
        //    if (productores == null)
        //    {
        //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
        //    }

        //    return productores;
        //}

        // PUT api/ApiProductores/5
        public HttpResponseMessage PutProductores(string id, Productores productores)
        {
            if (ModelState.IsValid && id == productores.ren)
            {
                db.Productores.Attach(productores);
                db.ObjectStateManager.ChangeObjectState(productores, EntityState.Modified);

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

        // POST api/ApiProductores
        public HttpResponseMessage PostProductores(Productores productores)
        {
            if (ModelState.IsValid)
            {
                db.Productores.AddObject(productores);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, productores);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = productores.ren }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/ApiProductores/5
        public HttpResponseMessage DeleteProductores(string id)
        {
            Productores productores = db.Productores.Single(p => p.ren == id);
            if (productores == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Productores.DeleteObject(productores);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, productores);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}