using System;

namespace Centric.UserRepository.Models
{
    public class Company
    {
        private String catchPhrase { get; set; }
        private String name { get; set; }
        private String bs { get; set; }

        public Company(string catchPhrase, string name, string bs)
        {
            this.catchPhrase = catchPhrase;
            this.name = name;
            this.bs = bs;
        }


    }
}