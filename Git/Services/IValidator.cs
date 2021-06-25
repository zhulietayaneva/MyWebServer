using Git.Controllers;
using Git.Models.Repositories;
using System.Collections.Generic;

namespace Git.Services
{
    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserFormModel model);
        ICollection<string> ValidateRepository(RepositoryFormModel model);
    }
}
