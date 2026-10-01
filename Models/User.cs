namespace  Refolio.Models;

    public class User: EntityBase
    {
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string PasswordSalt { get; set; }
        public required string Email { get; set; }
    }

