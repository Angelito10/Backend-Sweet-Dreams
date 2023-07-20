using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int Id { get; set; }
        public decimal? Total { get; set; }
        public int? ClienteId { get; set; }
        public int? MetodoPagoId { get; set; }
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual MetodoPago? MetodoPago { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
