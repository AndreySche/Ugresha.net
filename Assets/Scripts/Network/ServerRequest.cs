using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ugresha
{
    internal class ServerRequest
    {
        public VnuBase Get(UserAuth userAuth, Page page) => DefaultJson(page);

        private VnuBase DefaultJson(Page page)
        {
            JsonOffline offPrice = new JsonOffline();
            string priceJson = offPrice.Price();
            string userJson = offPrice.User();

            return new VnuBase()
            {
                Price = JsonConvert.DeserializeObject<Dictionary<int, PriceInfo>>(priceJson),
                User = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<string>>>>(userJson)
            };
        }
        // ""UserInfo"":   { ""login"": [ ""u007"" ] },
        // {""UserInfo"":   { ""login"": [ ""u007"" ] }},

        //private T ParsePages<T>(string value) => (T)Page.Parse(typeof(T), value, true); // enumParser
    }
}