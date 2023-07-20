using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Sucursal
    {
        public int Id { get; set; }
        public string? RazonSocial { get; set; }
        public string? Correo { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
    }
}
