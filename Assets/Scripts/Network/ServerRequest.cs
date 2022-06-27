using System.Collections.Generic;

namespace Ugresha
{
    internal class ServerRequest
    {
        public VnuBase Get(UserAuth userAuth, Page page)
        {
            VnuBase vnuBase = new VnuBase();

            // todo Get Or Set Coockies
            // offline mode
            vnuBase.Price = new List<VnuList>();
            vnuBase.Lfstrm = new List<VnuList>();
            vnuBase.UserInfo = userAuth.Guest ? GuestJson(page) : GuestJson(page); // todo getServer
            vnuBase.News = new List<VnuList>();

            return vnuBase;
        }

        private List<VnuList> GuestJson(Page page)
        {
            string json = @"
            {
                ""array"": [
                    {
                        ""Name"": ""UserInfo"",
                        ""Info"": { ""Title"": ""login"", ""Description"": [ ""u007"" ]}
                    },{
                        ""Name"": ""UserSms"",
                        ""Info"": { ""Title"": ""phone"", ""Description"": [ ""9160001122"" ]}
                    },{
                        ""Name"": ""PagePay"",
                        ""Info"": { ""Title"": ""balance"", ""Description"": [ ""1567,28234"" ]}
                    },{
                        ""Name"": ""PagePrice"",
                        ""Info"": { ""Title"": ""price"", ""Description"": [ 123 ]}
                    },{
                        ""Name"": ""UserHold"",
                        ""Info"": { ""Title"": ""hold"", ""Description"": [ 3 ]}
                    },{
                        ""Name"": ""UserTv"",
                        ""Info"": { ""Title"": ""tv"", ""Description"": [1, 2, 3]}
                    },{
                        ""Name"": ""UserCredit"",
                        ""Info"": { ""Title"": ""credit"", ""Description"": [ ""123,2"" ]}
                    },{
                        ""Name"": ""UserService"",
                        ""Info"": { ""Title"": ""service"", ""Description"": [ 79 ]}
                    },{
                        ""Name"": ""UserIp"",
                        ""Info"": { ""Title"": ""ip"", ""Description"": [ ""2a06:4180:1:0:0:0:0:0000"", ""10.184.0.0"" ]}
                    }
                ]
            }
            ";
            return JsonLister.getJsonArray<VnuList>(json);
        }
    }
}
