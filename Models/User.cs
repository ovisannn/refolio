namespace Refolio.Models;

public sealed class User: EntityBase
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }

        //private constructor for ORM 
        private User()
        {
            Username = string.Empty;
            PasswordHash = string.Empty;
            PasswordSalt = string.Empty;
            Email = string.Empty;
        }

        private User(string username, string passwordHash, string passwordSalt, string email)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Email = email;
        }

        public static User Create(string username, string passwordHash, string passwordSalt, string email)
        {
            return new User(username,passwordHash,passwordSalt,email);
        }
    }

