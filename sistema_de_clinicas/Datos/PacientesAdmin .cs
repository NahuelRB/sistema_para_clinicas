using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistema_de_clinicas.Models;

namespace sistema_de_clinicas.Datos
{
    public class PacientesAdmin
    {
        /// <summary>
        /// Consulta todos los personas
        /// </summary>
        /// <returns>Datos de los personas</returns>
        public IEnumerable<pacientes> ConsultarPaciente() {
            using (sistemaClinicaEntities contexto = new sistemaClinicaEntities()) {
                return contexto.pacientes.AsNoTracking().ToList();
            }
        }

    }
}