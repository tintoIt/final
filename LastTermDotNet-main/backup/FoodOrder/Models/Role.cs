﻿using System;
using System.Collections.Generic;

namespace FoodOrder.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
