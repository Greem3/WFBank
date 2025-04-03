using Newtonsoft.Json;

namespace Bank
{
    public class FormatterConfig : Json
    {
        public ConfigJson PathFormatter { get; set; }

        public class ConfigJson : Json
        {
            public int beforeFiles { get; set; }
            public bool afterFiles { get; set; }
            public string afterFilePath { get; set; }
        }
    }
}