using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Extensions.Library
{
    public static class StringExtensions
    {
        public static void SaveToDisk(this string data, string path)
        {
            File.WriteAllText(path, data);
        }

        public static object FromJson<T>(this string json)
        {            
            return JsonSerializer.Deserialize<T>(json);
        }

        public static string LoadFromFile(this string path)
        {
            return File.ReadAllText(path);
        }

        public static bool IsValidCultureInfoName(this string name)
        {
            return CultureInfo
                .GetCultures(CultureTypes.SpecificCultures)
                .Any(c => c.Name == name);
        }
    }
}
