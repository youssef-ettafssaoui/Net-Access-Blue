﻿using System;
namespace Manage_Access.Entities
{
	public class Permission
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}

