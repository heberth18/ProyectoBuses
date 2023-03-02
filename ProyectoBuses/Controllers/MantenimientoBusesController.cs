using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBuses.Models
{
    public class MantenimientoBusesController : Controller
    {
        private bd_ProyectoBusesEntities1 db = new bd_ProyectoBusesEntities1();

        // GET: MantenimientoBuses
        public ActionResult Index()
        {
            var bus = db.bus.Include(b => b.destino);
            return View(bus.ToList());
        }

        // GET: MantenimientoBuses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bus bus = db.bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // GET: MantenimientoBuses/Create
        public ActionResult Create()
        {
            ViewBag.id_destino = new SelectList(db.destino, "id_destino", "nombre");
            return View();
        }

        // POST: MantenimientoBuses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bus,marca_nombre,id_destino")] bus bus)
        {
            if (ModelState.IsValid)
            {
                db.bus.Add(bus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_destino = new SelectList(db.destino, "id_destino", "nombre", bus.id_destino);
            return View(bus);
        }

        // GET: MantenimientoBuses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bus bus = db.bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_destino = new SelectList(db.destino, "id_destino", "nombre", bus.id_destino);
            return View(bus);
        }

        // POST: MantenimientoBuses/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bus,marca_nombre,id_destino")] bus bus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_destino = new SelectList(db.destino, "id_destino", "nombre", bus.id_destino);
            return View(bus);
        }

        // GET: MantenimientoBuses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bus bus = db.bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: MantenimientoBuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bus bus = db.bus.Find(id);
            db.bus.Remove(bus);
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
    }
}
