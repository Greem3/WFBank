using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    static class Context
    {
        public static Config config { get; set; } = Json.NewInstanceFile<Config>();

        public static ActualUser actualUser { get; set; } = Json.NewInstanceFile<ActualUser>();

        public static SectionNames sections { get; set; } = Json.NewInstanceFile<SectionNames>();

        public static void Save()
        {
            JsonFile.SaveDataConfig(actualUser);
            JsonFile.SaveDataConfig(config);
        }

        public static void Reload()
        {
            actualUser = Json.NewInstanceFile<ActualUser>();
            config = Json.NewInstanceFile<Config>();
        }
    }
}
