using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PathFormatter = System.Formatter;

namespace Bank
{
    class TextFile
    {
        protected string _filePath;

        public TextFile(string filePath)
        {
            this._filePath = PathFormatter.PathFormat(filePath);
        }

        public TextFile(FileStream file)
        {
            this._filePath = file.Name;
            file.Close();
            file.Dispose();
        }

        /// <summary>
        /// Lee todo el texto del archivo
        /// </summary>
        /// <returns>string</returns>
        public string ReadAll()
        {
            return TextFile.ReadAll(this._filePath);
        }

        public static string ReadAll(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        /// <summary>
        /// Elimina todo el texto del archivo
        /// </summary>
        public void EraseAll()
        {
            TextFile.EraseAll(this._filePath);
        }

        public static void EraseAll(string filePath)
        {
            using (FileStream trash = new FileStream(filePath, FileMode.Truncate))
            {

            }
        }

        /// <summary>
        /// Escribe un texto al final del archivo
        /// </summary>
        /// <param name="text">Texto a escribir</param>
        public void Write(string text)
        {
            TextFile.Write(this._filePath, text);
        }

        public static void Write(string filePath, string text)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(text);
            }
        }

        /// <summary>
        /// Escribe una linea nueva en el archivo
        /// </summary>
        /// <param name="text">Texto a escribir</param>
        public void WriteLine(string text)
        {
            TextFile.WriteLine(this._filePath, text);
        }

        public static void WriteLine(string filePath, string text)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(text);
            }
        }

        /// <summary>
        /// Elimina todo el texto del archivo y escribe uno nuevo
        /// </summary>
        /// <param name="text">Texto nuevo que tendra el archivo</param>
        public void WriteAll(string text)
        {
            TextFile.WriteAll(this._filePath, text);
        }

        public static void WriteAll(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        public void Dispose()
        {
            this._filePath = null;
            GC.SuppressFinalize(this);
        }

        ~TextFile()
        {
            this.Dispose();
        }
    }
}