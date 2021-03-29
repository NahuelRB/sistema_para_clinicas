using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sistema_de_clinicas.Datos;
using sistema_de_clinicas.Models;

namespace sistema_de_clinicas.Controllers
{
    public class HomeController : Controller
    {
        PacientesAdmin paAdmin = new PacientesAdmin();
        PersonasAdmin peAdmin = new PersonasAdmin();
        ConsultasAdmin coAdmin = new ConsultasAdmin();
        MedicosAdmin meAdmin = new MedicosAdmin();

        public ActionResult index()
        {
            ViewBag.mensaje = "";
            return View();
        }
        public ActionResult Nuevo(consultas modelo)
        {
            coAdmin.guardarConsulta(modelo);
            ViewBag.mensaje = "Consulta guardada exitosamente";
            return View("index");
        }

        public ActionResult pacientes()
        {
            IEnumerable<pacientes> lista = paAdmin.ConsultarPaciente();
            return View(lista);
        }
        public ActionResult personas()
        {
            IEnumerable<personas> lista = peAdmin.consultarPersonas();
            return View(lista);
        }
        public ActionResult medicos()
        {
            IEnumerable<medicos> lista = meAdmin.consultarMedicos();
            return View(lista);
        }
        public ActionResult consultasMedicas()
        {
            IEnumerable<consultas> lista = coAdmin.ConsultarConsultasMedicas();
            return View(lista);
        }
    }
}