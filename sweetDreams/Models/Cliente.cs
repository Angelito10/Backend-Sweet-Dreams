using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string? Apellidos { get; set; }
        public string? Celular { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? Baja { get; set; }
        public int? UserId { get; set; }

        public virtual Usuario? User { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
