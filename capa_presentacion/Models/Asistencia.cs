using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_presentacion.Models
{
    internal class Asistencia
    {
        public int ID { get; set; }
        public int DocenteID { get; set; } // Relación con el Docente
        public Docente Docente { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; } // True = Asistió, False = No Asistió
        public bool DescuentoAplicado { get; set; } = false; // Si se aplicó descuento o no
        public string Observaciones { get; set; }

        // Método para verificar inasistencia
        public void VerificarInasistencia(Licencia licencia)
        {
            if (!Estado && licencia == null)
            {
                DescuentoAplicado = true;
            }
        }
    }
}
