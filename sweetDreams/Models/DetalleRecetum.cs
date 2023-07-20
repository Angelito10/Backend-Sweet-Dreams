using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class DetalleRecetum
    {
        public int Id { get; set; }
        public int? IngredienteId { get; set; }
        public decimal? Cantidad { get; set; }
        public string? Instruccion { get; set; }
        public int? UnidadMedidaId { get; set; }
        public int? RecetaId { get; set; }
        public int? Baja { get; set; }

        public virtual Ingrediente? Ingrediente { get; set; }
        public virtual Recetum? Receta { get; set; }
        public virtual UnidadMedidum? UnidadMedida { get; set; }
    }
}
