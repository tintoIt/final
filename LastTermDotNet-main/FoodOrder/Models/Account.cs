using System;
using System.Collections.Generic;

namespace FoodOrder.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Roles { get; set; }
        public string? Status { get; set; }

        public virtual Role? RolesNavigation { get; set; }
    }
}
