using System;
using System.Collections.Generic;

namespace Ugresha
{
    [Serializable]
    //public class ButtonInfo { public Dictionary<string, List<string>> ListString; }

    // ""UserInfo"":   { ""login"": [ ""u007"" ] },

    class ButtonInfo { public Info button; }
    class Info { public Dictionary<string, Description> button; }
    class Description { public List<string> stringArray; }


}
/*
     class Address { public City city { get; set; } }
    class City { public Street street { get; set; } }
    class Street { public House house { get; set; } }
    class House { public int number { get; set; } }
 */