using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistema_de_clinicas.Models;
namespace sistema_de_clinicas.Datos
{
    public class ConsultasAdmin
    {
        /// <summary>
        /// Consulta todos las consultas médicas
        /// </summary>
        /// <returns>Datos de los personas</returns>
        public IEnumerable<consultas> ConsultarConsultasMedicas() {
            using (sistemaClinicaEntities contexto = new sistemaClinicaEntities()) {
                return contexto.consultas.AsNoTracking().ToList();
            }
        }

        /// <summary>
        /// Guarda una consulta en la base de datos
        /// </summary>
        /// <Param name="modelo">Datos de la consulta</Param>
        public void guardarConsulta(consultas modelo) {
            using (sistemaClinicaEntities contexto = new sistemaClinicaEntities()) {
                contexto.consultas.Add(modelo);
                contexto.SaveChanges();
            }
        }

    }
}