using Newtonsoft.Json;

namespace Bank
{
    public class ActualUser : Json
    {
        public bool Acceded { get; set; }
        public InfoUser Info { get; set; }

        public class InfoUser : Json
        {
        }
    }
}