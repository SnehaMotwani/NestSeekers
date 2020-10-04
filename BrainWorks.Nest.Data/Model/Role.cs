using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
