using UnityEngine;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Ugresha
{
    class JsonLister
    {
        public static List<T> getJsonArray<T>(string json)
        {
            if (json.Substring(0, 1) == "{") json = $"[{json}]";    // andreySche
            string newJson = "{ \"array\": " + json + "}";
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.array;
        }

        public static string arrayToJson<T>(List<T> array, bool prettyPrint = false)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.array = array;
            return JsonUtility.ToJson(wrapper, prettyPrint);
        }

        [System.Serializable]
        private class Wrapper<T> { public List<T> array; }

        public static string Unicode(string result)
        {
            Regex rx = new Regex(@"\\[uU]([0-9A-F]{4})");
            return rx.Replace(result, match => ((char)int.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
        }
    }
}
