using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_presentacion.Models
{
    internal class Docente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        // Relación: un docente puede tener varias asistencias
        public ICollection<Asistencia> Asistencias { get; set; }
        public ICollection<Licencia> Licencias { get; set; }
    }
}
