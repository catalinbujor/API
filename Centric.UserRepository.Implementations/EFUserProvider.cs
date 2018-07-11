using System.Collections.Generic;
using Centric.UserRepository.Models;
using Centric.UsersRepository.Interfaces;

namespace Centric.UserRepository.Implementations
{
    public class EFUserProvider : IUserDataProvider
    {
        public List<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}