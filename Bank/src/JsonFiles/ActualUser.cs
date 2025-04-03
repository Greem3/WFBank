using Newtonsoft.Json;

namespace Bank
{
    public class ActualUser : Json
    {
        public bool Acceded { get; set; }
        
        public InfoUser Info { get; set; }

        public class InfoUser : Json
        {
            public long id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string profilePicture { get; set; }
            public bool isAdmin { get; set; }
        }
    }
}