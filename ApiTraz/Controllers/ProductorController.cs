﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiTraz.Controllers
{
    public class ProductorController : Controller
    {
       

        public ActionResult Index()
        {
            return View();
        }

      
        public ActionResult Details(int id)
        {
            return View();
        }

     

        public ActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Productor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Productor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Productor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Productor/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
