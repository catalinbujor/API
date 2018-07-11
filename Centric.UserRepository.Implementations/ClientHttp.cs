using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    public class ClientHttp
    {
        public async Task<string> GetResponse()
        {
            string page= "https://jsonplaceholder.typicode.com/users";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                if (result != null)
                {
                    
                    return result;

                }

                return null;
            }
        }
    }
}

