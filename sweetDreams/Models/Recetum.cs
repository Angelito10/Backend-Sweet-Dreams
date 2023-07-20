using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Recetum
    {
        public Recetum()
        {
            DetalleReceta = new HashSet<DetalleRecetum>();
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string? Receta { get; set; }
        public string? Descripcion { get; set; }
        public int? Duracion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? Baja { get; set; }

        public virtual ICollection<DetalleRecetum> DetalleReceta { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
