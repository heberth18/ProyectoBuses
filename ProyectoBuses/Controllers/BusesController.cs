using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoBuses.Models;

namespace ProyectoBuses.Controllers
{
    public class BusesController : Controller
    {
        // GET: Buses

        bd_ProyectoBusesEntities1 entidad = new bd_ProyectoBusesEntities1();
        public ActionResult Index()
        {
            var listadestinos = entidad.destino;
            return View(listadestinos.ToList());
        }

        public  ActionResult ListaMaestraDestino()
        {
            var listadestinos = entidad.destino;
            return View(listadestinos.ToList());
        }


        public ActionResult ListaBuses()  
        {
            var listabuses = entidad.bus;
            return View(listabuses.ToList());
        }

        public ActionResult ListaPasajes()
        {
            var listapasajes = entidad.pasaje;
            return View(listapasajes.ToList());
        }
    }
}