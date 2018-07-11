using System.Collections.Generic;
using Centric.UserRepository.Models;
using Centric.UsersRepository.Interfaces;

namespace Centric.UserRepository.Implementations
{
    public class CacheManager : ICacheManager
    {
        private readonly List<User> users;

        public CacheManager()
        {
            users = new List<User>();
        }

        public bool CanCache()
        {
            return users.Count == 0;
        }

        public void Cache(List<User> users)
        {
            this.users.AddRange(users);
        }

        public List<User> RetrieveFromCache()
        {
            return this.users;
        }
    }
}