using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Entrada
    {
        public int Id { get; set; }
        public int? IngredienteId { get; set; }
        public int? UnidadMedidaId { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public int? UserId { get; set; }

        public virtual Ingrediente? Ingrediente { get; set; }
        public virtual UnidadMedidum? UnidadMedida { get; set; }
        public virtual Usuario? User { get; set; }
    }
}
