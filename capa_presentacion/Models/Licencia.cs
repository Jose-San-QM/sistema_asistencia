using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_presentacion.Models
{
    internal class Licencia
    {
        public int ID { get; set; }
        public int DocenteID { get; set; }
        public Docente Docente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Motivo { get; set; }

        // Método para validar licencia dentro de un rango de fechas
        public bool EsValida(DateTime fecha)
        {
            return fecha >= FechaInicio && fecha <= FechaFin;
        }
    }
}
