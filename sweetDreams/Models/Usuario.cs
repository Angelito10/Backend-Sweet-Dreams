using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Clientes = new HashSet<Cliente>();
            Compras = new HashSet<Compra>();
            Empleados = new HashSet<Empleado>();
            Entrada = new HashSet<Entrada>();
            Inventarios = new HashSet<Inventario>();
            Salida = new HashSet<Salida>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Password { get; set; }
        public int? Active { get; set; }
        public DateTime? ConfirmedAt { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<Salida> Salida { get; set; }
    }
}
