using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
        }

        public int Id { get; set; }
        public string? RazonSocial { get; set; }
        public string? Rfc { get; set; }
        public string? Alias { get; set; }
        public int? Baja { get; set; }
        public string? Correo { get; set; }
        public string? Celular { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
