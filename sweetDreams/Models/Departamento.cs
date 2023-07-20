using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Departamento1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
