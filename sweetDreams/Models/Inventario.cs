using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public decimal? ExistenciaInicial { get; set; }
        public decimal? ExistenciaActual { get; set; }
        public int? UnidadMedidaId { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? IngredienteId { get; set; }
        public int? UserId { get; set; }

        public virtual Ingrediente? Ingrediente { get; set; }
        public virtual UnidadMedidum? UnidadMedida { get; set; }
        public virtual Usuario? User { get; set; }
    }
}
