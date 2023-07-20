using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int Id { get; set; }
        public decimal? Total { get; set; }
        public int? ClienteId { get; set; }
        public int? MetodoPagoId { get; set; }
        public int? Baja { get; set; }
        public string? EstatusPedido { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual MetodoPago? MetodoPago { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
