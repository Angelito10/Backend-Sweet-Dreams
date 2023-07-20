using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class DetalleCompra
    {
        public int Id { get; set; }
        public int? CompraId { get; set; }
        public int? IngredienteId { get; set; }
        public int? UnidadMedidaId { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Iva { get; set; }
        public int? Baja { get; set; }

        public virtual Compra? Compra { get; set; }
        public virtual Ingrediente? Ingrediente { get; set; }
        public virtual UnidadMedidum? UnidadMedida { get; set; }
    }
}
