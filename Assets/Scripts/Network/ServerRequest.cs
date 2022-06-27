using System.Collections.Generic;

namespace Ugresha
{
    internal class ServerRequest
    {
        public List<VnuList> Get(UserAuth userAuth, Page page)
        {
            List<VnuList> content = null;
            switch (page)
            {
                case (Page.PageMain): content = PageMainListJson(); break;

            }
            return content;
        }

        private List<VnuList> PageMainListJson()
        {
            string json = @"
            {
                ""array"": [
                    {
                        ""Name"": ""UserInfo"",
                        ""Info"": { ""Title"": ""login"", ""Description"": [ ""u8986"" ]}
                    },{
                        ""Name"": ""UserSms"",
                        ""Info"": { ""Title"": ""phone"", ""Description"": [ ""0165022021"" ]}
                    },{
                        ""Name"": ""PagePay"",
                        ""Info"": { ""Title"": ""balance"", ""Description"": [ ""1567.28"" ]}
                    },{
                        ""Name"": ""PagePrice"",
                        ""Info"": { ""Title"": ""price"", ""Description"": [ ""123"" ]}
                    },{
                        ""Name"": ""UserHold"",
                        ""Info"": { ""Title"": ""hold"", ""Description"": [ ""0"" ]}
                    },{
                        ""Name"": ""UserTv"",
                        ""Info"": { ""Title"": ""tv"", ""Description"": [ ""[1, 2, 3]"" ]}
                    },{
                        ""Name"": ""UserCredit"",
                        ""Info"": { ""Title"": ""credit"", ""Description"": [ ""123.02"" ]}
                    },{
                        ""Name"": ""UserService"",
                        ""Info"": { ""Title"": ""service"", ""Description"": [ ""[25]"" ]}
                    },{
                        ""Name"": ""UserIp"",
                        ""Info"": { ""Title"": ""ip"", ""Description"": [ ""10.184.10.1"" ]}
                    }
                ]
            }
            ";
            return JsonLister.getJsonArray<VnuList>(json);
        }

        //private List<VnuList> PageMainList()
        //{
        //    List<VnuList> list = new List<VnuList> {
        //    new VnuList(){ Name = "UserInfo", Info = new VnuInfo() { Title = "login", Description = new List<string>(){ "u8986" } } },
        //    new VnuList() { Name = "UserSms", Info = new VnuInfo() { Title = "phone", Description = new List<string>(){"0165022021" } } },
        //    new VnuList() { Name = "PagePay", Info = new VnuInfo() { Title = "balance", Description = new List<string>(){"1567.28" } } },
        //    new VnuList() { Name = "PagePrice", Info = new VnuInfo() { Title = "price", Description = new List<string>(){"123"} } },
        //    new VnuList() { Name = "UserHold", Info = new VnuInfo() { Title = "hold", Description = new List<string>(){"0"} } },
        //    new VnuList() { Name = "UserTv", Info = new VnuInfo() { Title = "tv", Description = new List<string>(){"[1, 2, 3]"} } },
        //    new VnuList() { Name = "UserCredit", Info = new VnuInfo() { Title = "credit", Description = new List<string>(){"123.02"}  } },
        //    new VnuList() { Name = "UserService", Info = new VnuInfo() { Title = "service", Description = new List<string>(){"[25]"} } },
        //    new VnuList() { Name = "UserIp", Info = new VnuInfo() { Title = "ip", Description = new List<string>(){"10.184.10.1"} } }
        //    };
        //    return list;
        //}
    }
}
