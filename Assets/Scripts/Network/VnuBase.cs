using System.Collections.Generic;

namespace Ugresha
{
    public class VnuBase
    {
        public Dictionary<int, PriceInfo> Price;
        public Dictionary<int, string> HoldDictionary;
        public Dictionary<string, Dictionary<string, List<string>>> User;
        //public List<Price> LfstrmList;
        //public List<Price> NewsList;
        //public List<Price> AlertList;
    }
}
