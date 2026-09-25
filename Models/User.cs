using System.Runtime.InteropServices.JavaScript;

namespace  Refolio.Models
{
    public class User
    {
        public required long Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }
    }
}

