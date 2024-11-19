using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TarjetasPresentacionMVC.Models;
using System.Web.Mvc;

namespace TarjetasPresentacionMVC.Controllers
{
    public class TarjetaController : Controller
    {
        // Acción para mostrar el formulario inicial
        public ActionResult Index()
        {
            // Devuelve la vista con un modelo vacío
            return View(new Tarjeta());
        }

        // Acción para procesar los datos del formulario
        [HttpPost] // Solo acepta peticiones POST (cuando se envía el formulario)
        public ActionResult Index(Tarjeta tarjeta)
        {
            // Devuelve la vista de vista previa con los datos ingresados
            return View("VistaPrevia", tarjeta);
        }
    }
}