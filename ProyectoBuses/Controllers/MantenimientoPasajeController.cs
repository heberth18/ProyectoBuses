using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoBuses.Models;

namespace ProyectoBuses.Controllers
{
    public class MantenimientoPasajeController : Controller
    {
        private bd_ProyectoBusesEntities1 db = new bd_ProyectoBusesEntities1();

        // GET: MantenimientoPasaje
        public ActionResult Index()
        {
            var pasaje = db.pasaje.Include(p => p.bus).Include(p => p.cliente);
            return View(pasaje.ToList());
        }

        // GET: MantenimientoPasaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pasaje pasaje = db.pasaje.Find(id);
            if (pasaje == null)
            {
                return HttpNotFound();
            }
            return View(pasaje);
        }

        // GET: MantenimientoPasaje/Create
        public ActionResult Create()
        {
            ViewBag.id_bus = new SelectList(db.bus, "id_bus", "marca_nombre");
            ViewBag.rut_cliente = new SelectList(db.cliente, "rut_cliente", "cliente_nombre");
            return View();
        }

        // POST: MantenimientoPasaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_pasaje,id_bus,rut_cliente,precio,fecha")] pasaje pasaje)
        {
            if (ModelState.IsValid)
            {
                db.pasaje.Add(pasaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_bus = new SelectList(db.bus, "id_bus", "marca_nombre", pasaje.id_bus);
            ViewBag.rut_cliente = new SelectList(db.cliente, "rut_cliente", "cliente_nombre", pasaje.rut_cliente);
            return View(pasaje);
        }

        // GET: MantenimientoPasaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pasaje pasaje = db.pasaje.Find(id);
            if (pasaje == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_bus = new SelectList(db.bus, "id_bus", "marca_nombre", pasaje.id_bus);
            ViewBag.rut_cliente = new SelectList(db.cliente, "rut_cliente", "cliente_nombre", pasaje.rut_cliente);
            return View(pasaje);
        }

        // POST: MantenimientoPasaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_pasaje,id_bus,rut_cliente,precio,fecha")] pasaje pasaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pasaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_bus = new SelectList(db.bus, "id_bus", "marca_nombre", pasaje.id_bus);
            ViewBag.rut_cliente = new SelectList(db.cliente, "rut_cliente", "cliente_nombre", pasaje.rut_cliente);
            return View(pasaje);
        }

        // GET: MantenimientoPasaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pasaje pasaje = db.pasaje.Find(id);
            if (pasaje == null)
            {
                return HttpNotFound();
            }
            return View(pasaje);
        }

        // POST: MantenimientoPasaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pasaje pasaje = db.pasaje.Find(id);
            db.pasaje.Remove(pasaje);
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
