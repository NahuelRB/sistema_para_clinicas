using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistema_de_clinicas.Models;

namespace sistema_de_clinicas.Datos
{
    public class PersonasAdmin
    {
        /// <summary>
        /// Consulta todos los personas
        /// </summary>
        /// <returns>Datos de los personas</returns>
        public IEnumerable<personas> consultarPersonas() {
            using (sistemaClinicaEntities contexto = new sistemaClinicaEntities()) {
                return contexto.personas.AsNoTracking().ToList();
            }
        }

    }
}