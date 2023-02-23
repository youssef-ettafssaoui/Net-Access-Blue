using System;
using Microsoft.AspNetCore.Identity;

namespace Manage_Access.Entities
{
	public class Role : IdentityRole<int>
    {
        public ICollection<RolePermission> RolePermissions { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}

