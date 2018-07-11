using System.Collections.Generic;
using Centric.UserRepository.Models;
using Centric.UsersRepository.Interfaces;
using Newtonsoft.Json;
using TodoApi.Controllers;

namespace Centric.UserRepository.Implementations
{   public class UrlUserDataProvider : IUserDataProvider
    {
        private readonly ICacheManager cacheManager;

        public UrlUserDataProvider(ICacheManager cacheManager)
        {
            this.cacheManager = cacheManager;
        }

        public List<User> GetUsers()
        {
            if (cacheManager.CanCache())
            {
                var users = GetUsersFromHttp();

                cacheManager.Cache(users);

                return users;
            }

            return cacheManager.RetrieveFromCache();
        }

        private List<User> GetUsersFromHttp()
        {
            var client = new ClientHttp();

            var response = client.GetResponse().Result;
            
            return JsonConvert.DeserializeObject<List<User>>(response);
        }
    }
}
