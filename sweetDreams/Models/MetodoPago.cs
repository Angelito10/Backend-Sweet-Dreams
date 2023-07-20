using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Compras = new HashSet<Compra>();
            Pedidos = new HashSet<Pedido>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string? MetodoPago1 { get; set; }
        public string? Descripcion { get; set; }
        public int? Baja { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
