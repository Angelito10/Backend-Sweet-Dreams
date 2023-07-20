using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Ingrediente
    {
        public Ingrediente()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
            DetalleReceta = new HashSet<DetalleRecetum>();
            Entrada = new HashSet<Entrada>();
            Inventarios = new HashSet<Inventario>();
            Salida = new HashSet<Salida>();
        }

        public int Id { get; set; }
        public string? Ingrediente1 { get; set; }
        public decimal? StockMinimo { get; set; }
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? UnidadMedidaId { get; set; }

        public virtual UnidadMedidum? UnidadMedida { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleRecetum> DetalleReceta { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<Salida> Salida { get; set; }
    }
}
