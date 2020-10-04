using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public List<UserRole> UsersRoles { get; set; }
    }
}
