using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Extensions.Library
{
    public static class IEnumerableExtensions
    {
        public static string ToJson<T>(this IEnumerable<T> data)
        {
            var json = JsonSerializer.Serialize(data);

            return json;
        }
    }
}
