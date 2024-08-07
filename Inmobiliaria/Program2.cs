using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Inmobiliaria.Models;

namespace Inmobiliaria.Services
{
    public static class FileService<T>
    {
        private static string GetFilePath()
        {
            return typeof(T).Name.ToLower() + ".json";
        }

        public static List<T> Leer()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static void Guardar(List<T> items)
        {
            string filePath = GetFilePath();
            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
