using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string? ApePaterno { get; set; }
        public string? ApeMaterno { get; set; }
        public string? FotoEmpleado { get; set; }
        public string? Rfc { get; set; }
        public string? Curp { get; set; }
        public string? NumSeguroSocial { get; set; }
        public string? Celular { get; set; }
        public string? Alergias { get; set; }
        public string? Observaciones { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public int? Baja { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public int? DepartamentoId { get; set; }
        public int? UserId { get; set; }

        public virtual Departamento? Departamento { get; set; }
        public virtual Usuario? User { get; set; }
    }
}
