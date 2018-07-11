using System.Collections.Generic;
using Centric.UserRepository.Models;

namespace Centric.UsersRepository.Interfaces
{
    public interface IUserDataProvider
    {
        List<User> GetUsers();
    }
}
