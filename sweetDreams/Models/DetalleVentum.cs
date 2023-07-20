using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class DetalleVentum
    {
        public int Id { get; set; }
        public int? VentaId { get; set; }
        public int? MenuId { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Iva { get; set; }
        public int? Baja { get; set; }

        public virtual Menu? Menu { get; set; }
        public virtual Venta? Venta { get; set; }
    }
}
