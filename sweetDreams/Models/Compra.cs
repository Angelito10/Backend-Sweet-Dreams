using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int Id { get; set; }
        public decimal? Total { get; set; }
        public int? ProveedorId { get; set; }
        public int? MetodoPagoId { get; set; }
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? UserId { get; set; }

        public virtual MetodoPago? MetodoPago { get; set; }
        public virtual Proveedor? Proveedor { get; set; }
        public virtual Usuario? User { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
