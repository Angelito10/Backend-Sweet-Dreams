using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
