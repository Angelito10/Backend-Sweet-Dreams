using System;
using System.Collections.Generic;

namespace sweetDreams.Models
{
    public partial class RolesUser
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
    }
}
