using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class UnidadMedidum
    {
        public UnidadMedidum()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
            DetalleReceta = new HashSet<DetalleRecetum>();
            Entrada = new HashSet<Entrada>();
            Ingredientes = new HashSet<Ingrediente>();
            Inventarios = new HashSet<Inventario>();
            Salida = new HashSet<Salida>();
        }

        public int Id { get; set; }
        public string? Unidad { get; set; }

        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleRecetum> DetalleReceta { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<Salida> Salida { get; set; }
    }
}
