using System;
using System.Collections.Generic;

namespace Ugresha
{
    [Serializable]
    public class PriceInfo
    {
        public int Index;
        public string Title;
        public string Cost;
        public string Speed;
        public string Close;
        public string Delete;
    }

    [Serializable]
    public class PriceList { public int Index; public PriceInfo Info; }
}