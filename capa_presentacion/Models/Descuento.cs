using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_presentacion.Models
{
    internal class Descuento
    {
        public int ID { get; set; }
        public int DocenteID { get; set; }
        public Docente Docente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public static decimal CalcularDescuento(Docente docente)
        {
            // Ejemplo: descuento fijo de 50
            return 50m;
        }

        public void AplicarDescuento(Docente docente)
        {
            Monto = CalcularDescuento(docente);
            Fecha = DateTime.Now;
        }
    }
}
