using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class GrantController : Controller
    {
        // GET: Grant
        public ActionResult Index()
        {
            return View();
        }

        // GET: Grant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grant/Create
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

        // GET: Grant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grant/Edit/5
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

        // GET: Grant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grant/Delete/5
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
