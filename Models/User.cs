using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public string Password { get; set; }

    }
}
