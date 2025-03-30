using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class JsonFile : TextFile
    {


        /// <summary>
        /// Abre un archivo JSON
        /// </summary>
        /// <param name="filePath">directorio del archivo</param>
        /// <exception cref="Exception"></exception>
        public JsonFile(string filePath) : base(filePath)
        {
            if (!filePath.EndsWith(".json"))
            {
                throw new Exception("This file doesn't a Json!");
            }
        }

        public void SaveData(string json)
        {
            this.WriteAll(json);
        }

        public void SaveData(Json json)
        {
            this.WriteAll(json.Serialize());
        }

        public static void SaveData(string path, string json)
        {
            TextFile.WriteAll(path, json);
        }

        public static void SaveData(string path, Json json)
        {
            TextFile.WriteAll(path, json.Serialize());
        }

        public static void SaveDataConfig(Json json)
        {
            Type type = json.GetType();

            TextFile.WriteAll(Formatter.PathFormat($"ProjectConfig/{type.Name}.json"), json.Serialize());
        }
    }
}