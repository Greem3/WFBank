using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace System
{
    static class Formatter
    {
        public static string PathFormat(string normalPath)
        {
            Dictionary<string, object> data = Json.NewVarFile<FormatterConfig>
                    ("../../../src/PathFormatter/Formatter.config")
                .PathFormatter.GetDict();

            StringBuilder newString = new StringBuilder(normalPath);

            Dictionary<string, Action<object>> actions = new Dictionary<string, Action<object>>()
            {
                ["beforeFiles"] = (object value) =>
                {
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        newString.Insert(0, "../");
                    }
                },
                ["afterFiles"] = (object value) =>
                {
                    if (Convert.ToBoolean(value))
                    {
                        newString.Append("/" + data["afterFilePath"]);
                    }
                }
            };

            foreach (string key in data.Keys)
            {

                if (actions.TryGetValue(key, out var action))
                {
                    action(data[key]);
                }
            }

            return newString.ToString();
        }
    }
}