using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones_MySQL.modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string ClaveENA_13 { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public bool Descontinuado { get; set; }

        public string? Descripcion { get; set; }
        public int? ContenidoNetogr { get; set; }

    }
}
