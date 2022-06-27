using System;
using System.Collections.Generic;

namespace Ugresha
{
    [Serializable]
    public class Vnu { public string Title; public string[] Description; }

    [Serializable]
    public class VnuLine { public string Name; public Vnu Info; }



    [Serializable]
    public class VnuInfo { public string Title; public List<string> Description; }


    [Serializable]
    public class VnuList { public string Name; public VnuInfo Info; }
}