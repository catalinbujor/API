using System.Collections.Generic;
using Centric.UserRepository.Models;

namespace Centric.UsersRepository.Interfaces
{
    public interface ICacheManager
    {
        bool CanCache();

        void Cache(List<User> users);

        List<User> RetrieveFromCache();
    }
}