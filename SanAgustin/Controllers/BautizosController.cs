using SanAgustin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SanAgustin.Controllers
{
    public class BautizosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private DataClasses1DataContext context = new DataClasses1DataContext();
        // GET: Bautizos
        public ActionResult Index()
        {
            var bautizos = db.Bautizos;
            return View(bautizos.ToList());
        }

        //Get: Bautizos / Create
        public ActionResult Create()
        {
            ViewBag.BautizosId = new SelectList(db.Bautizos, "BautizoId", "Bautizado");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
                "BautizoId,Bautizado,FechaBautizo,LugarBautizo,PadreBautizado,CedPadre,MadreBautizado,Cedmadre,PadrinoBautizado,CedPadrino,Representante,Cedrepresentante,Comentario,Celebrante")]
            Bautizos bautizos)
        {
            if (ModelState.IsValid)
            {
                db.Bautizos.Add(bautizos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BautizoId = new SelectList(db.Bautizos, "BautizoId", "Bautizado", bautizos.BautizoId);
            return View(bautizos);
        }

        //Get: Bautizos/ Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bautizos bautizos = db.Bautizos.Find(id);
            if (bautizos == null)
            {
                return HttpNotFound();
            }

            ViewBag.BautizoId = new SelectList(db.Bautizos, "BautizoId", "Bautizado", bautizos.BautizoId);
            return View(bautizos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include =
                "BautizoId,Bautizado,FechaBautizo,LugarBautizo,PadreBautizado,CedPadre,MadreBautizado,Cedmadre,PadrinoBautizado,Cedpadrino,Representate,Cedrepresentante,Comentario,Celebrante")]
            Bautizos bautizos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bautizos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BautizoId = new SelectList(db.Bautizos, "BautizoId", "Bautizado", bautizos.BautizoId);
            return View(bautizos);
        }

        //Get: Bautizos / Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bautizos bautizos = db.Bautizos.Find(id);
            if (bautizos == null)
            {
                return HttpNotFound();
            }

            return View(bautizos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bautizos bautizos = db.Bautizos.Find();
            db.Bautizos.Remove(bautizos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

        //Get: Bautizos / Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bautizos bautizos = db.Bautizos.Find(id);
            if (bautizos == null)
            {
                return HttpNotFound();
            }

            return View(bautizos);
        }

        //public ActionResult buscar(string id)
        //{
        //    if (id == null)
        //    {
        //        id = Request["Texto"];
        //    }

        //    if (id == "")
        //    {
        //        id = null;
        //    }
        //    var bautizos = from b in db.Bautizos
        //        join
        //}

    }
}