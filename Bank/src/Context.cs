using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    static class Context
    {
        private static readonly string ActualUserPath = "../../ProjectConfig/ActualUser.json";

        public static ActualUser actualUser { get; set; } = Json.NewInstanceFile<ActualUser>();

        public static void Update()
        {
            JsonFile.SaveData(ActualUserPath, actualUser);
        }

        public static void Reload()
        {
            Context.actualUser = Json.NewInstanceFile<ActualUser>();
        }
    }
}
