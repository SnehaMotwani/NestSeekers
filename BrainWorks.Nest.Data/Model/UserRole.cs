using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public int RoleId { get; set; } //FK
        public int UserId { get; set; } //FK
        public Role Role { get; set; }
        public User User { get; set; }

        public List<User> Users { get; set; }
    }
}
