using System.Collections.Generic;
using System;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;

namespace Bank
{
    public abstract class Json
    {
        private static readonly string _defaultConfigPath = "../../ProjectConfig";

        public int Count
        {
            get
            {
                Type ClassType = this.GetType();

                PropertyInfo[] properties = ClassType.GetProperties();

                return properties.Length - 2;
            }
        }

        /// <summary>
        /// Crea una nueva instancia segun un texto json
        /// </summary>
        /// <typeparam name="T">Keys del Json</typeparam>
        /// <param name="json">Texto json</param>
        /// <returns>T</returns>
        public static T NewInstance<T>(string json)
        {
            Type type = typeof(T);
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Crea una clase AnyJson con una carpeta predeterminada
        /// Busca el archivo con el mismo nombre
        /// </summary>
        /// <typeparam name="T">Clase que se va a instanciar</typeparam>
        /// <returns>AnyJson</returns>
        public static T NewInstanceFile<T>()
        {
            return Json.NewInstanceFile<T>(_defaultConfigPath);
        }

        /// <summary>
        /// Crea una nueva instancia de una clase AnyJson segun una carpeta
        /// (Asegurate de que el directorio no termine con /)
        /// </summary>
        /// <typeparam name="T">Clase AnyJson que se va a devolver</typeparam>
        /// <param name="fromPath">Directorio del archivo del proyecto</param>
        /// <param name="addedExtension">Agrega extensiones de archivos extras</param>
        /// <returns>Informacion del Json segun la clase</returns>
        /// <example>AnyJson.NewInstanceFile("Mi Directorio")</example>
        public static T NewInstanceFile<T>(string fromPath, string[] addedExtension = null)
        {
            Type type = typeof(T);

            StringBuilder extensions = new StringBuilder();

            if (addedExtension != null)
            {
                foreach (string extension in addedExtension)
                {
                    extensions.Append($".{extension}");
                }
            }

            return JsonConvert.DeserializeObject<T>(
                JsonFile.ReadAll(
                    $"{fromPath}/{type.Name}{extensions}.json"
                    )
                );
        }

        /// <summary>
        /// Devuelve un diccionario con tipos de datos variables
        /// </summary>
        /// <typeparam name="TV">Tipo de los values</typeparam>
        /// <param name="fromPath">Directorio del archivo (sin .json)</param>
        /// <returns>Dictionary con Key string y Values TV</returns>
        public static Dictionary<string, TV> NewInstanceDictFile<TV>(string fromPath)
        {
            return Json.NewVarFile<Dictionary<string, TV>>(fromPath);
        }

        /// <summary>
        /// Crea una instancia de un objeto NO AnyJson para clases precreadas como diccionarios
        /// </summary>
        /// <typeparam name="T">Tipo NO AnyJson</typeparam>
        /// <param name="fromPath">Directorio del archivo (sin .json)</param>
        /// <returns>Clase con los valores del Json</returns>
        public static T NewVarFile<T>(string fromPath)
        {
            return JsonConvert.DeserializeObject<T>(JsonFile.ReadAll($"{fromPath}.json"));
        }

        public dynamic this[string keyName]
        {
            get => this.GetValue(keyName);
        }

        public dynamic GetValue(string key)
        {
            PropertyInfo value = this._GetProperty(key);

            return value.GetValue(this);
        }

        public void SetValue(string key, object newValue)
        {
            PropertyInfo property = this._GetProperty(key);

            Type propertyType = property.GetType();

            property.SetValue(this, newValue);
        }

        private PropertyInfo _GetProperty(string propertyName)
        {
            Type type = this.GetType();
            return type.GetProperty(propertyName);
        }

        private PropertyInfo _SearchProperty(string propertyName)
        {
            Type type = this.GetType();

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public);

            return properties.Where(m => m.Name == propertyName).ToArray()[0];
        }

        public Dictionary<string, object> GetDict()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            Type type = this.GetType();

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "Count")
                    continue;

                if (property.GetIndexParameters().Length > 0)
                    continue;

                object value = property.GetValue(this);

                if (value is Json anyValue)
                {
                    dict[property.Name] = anyValue.GetDict();
                    continue;
                }

                if (value is null)
                {
                    dict[property.Name] = null;
                }


                dict[property.Name] = value;
            }

            return dict;
        }

        public string Serialize()
        {
            return this.ToString();
        }

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this.GetDict(), Formatting.Indented);
        }
    }
}