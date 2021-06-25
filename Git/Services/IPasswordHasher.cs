using System.Collections.Generic;

namespace Git.Services
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}
