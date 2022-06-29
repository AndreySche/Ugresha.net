using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ugresha
{
    internal class ToJsonExample
    {
        private void ArrayToJson(string json)
        {
            json = @"
 {
    ""Price"": [
        {""Name"":""Andrey"",""Age"":18},
        {""Name"":""Max"",""Age"":10},{""Name"":""Kate"",""Age"":7}
    ],
    ""UserInfo"": [
        {""Name"":""Andrey"",""Age"":18},{""Name"":""Max"",""Age"":10},{""Name"":""Kate"",""Age"":7}
    ],
}
";
            var dict = @"
        {
            152: {
                ""title"": ""[22] Хватит на всех"",
                ""price"": 400,
                ""speed"": 100,
                ""amigo"": 1,
                ""del"": 0
            },
            151: {
                ""title"": ""[22] 999-пятьсот"",
                ""price"": 999,
                ""speed"": 500,
                ""amigo"": 0,
                ""del"": 0
            }
        }
";
            //var dictList = JsonConvert.DeserializeObject<Dictionary<int, List<PriceInfo>>>(dict);
            var dictList = JsonConvert.DeserializeObject<Dictionary<int, PriceInfo>>(dict);
            Debug.Log(dictList[151].Title);

            var price = JObject.Parse(json)["Price"].ToArray();
            var userInfo = JObject.Parse(json)["UserInfo"].ToArray();
            /*foreach (dynamic item in price)
            {
                Debug.Log($"{item.Index}");
                //Debug.Log($"{item.Link} : {item.Value}");
            }
            foreach (dynamic item in userInfo)
            {
                Debug.Log($"{item.Age}");
                //Debug.Log($"{item.Link} : {item.Value}");
            }*/
            /*foreach (var item in dictList)
            {
                //Debug.Log($"{item.Age}");
                string msg = $"{item.Link}: ";
                msg += item.Value.Title;
                Debug.Log(msg);
            }*/
        }

    }
}
