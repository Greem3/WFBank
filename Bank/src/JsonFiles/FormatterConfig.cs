using Newtonsoft.Json;

namespace Bank
{
    public class FormatterConfig : Json
    {
        public Config PathFormatter { get; set; }

        public class Config : Json
        {
            public int beforeFiles { get; set; }
            public bool afterFiles { get; set; }
            public string afterFilePath { get; set; }
        }
    }
}