using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Menu
    {
        public Menu()
        {
            DetallePedidos = new HashSet<DetallePedido>();
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int Id { get; set; }
        public int? RecetaId { get; set; }
        public string? Foto { get; set; }
        public decimal? Costo { get; set; }
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }

        public virtual Recetum? Receta { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
