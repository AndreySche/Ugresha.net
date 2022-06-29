namespace Ugresha
{
    internal class JsonOffline
    {
        private string _jsonPrice;

        public string Price()
        {
            return @"
{
    ""152"": {
        ""title"": ""[22] Хватит на всех"",
        ""price"": 400,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""151"": {
        ""title"": ""[22] 999-пятьсот"",
        ""price"": 999,
        ""speed"": 500,
        ""amigo"": 0,
        ""del"": 0
    },
    ""150"": {
        ""title"": ""[22] 800-двести"",
        ""price"": 800,
        ""speed"": 200,
        ""amigo"": 0,
        ""del"": 0
    },
    ""149"": {
        ""title"": ""[22] 600-сто"",
        ""price"": 600,
        ""speed"": 100,
        ""amigo"": 0,
        ""del"": 0
    },
    ""148"": {
        ""title"": ""[22] 550-любимый"",
        ""price"": 550,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""146"": {
        ""title"": ""[22] 550+тв"",
        ""price"": 550,
        ""speed"": 75,
        ""amigo"": 0,
        ""del"": 0
    },
    ""153"": {
        ""title"": ""[22] 400-любимый"",
        ""price"": 400,
        ""speed"": 75,
        ""amigo"": 1,
        ""del"": 0
    },
    ""142"": {
        ""title"": ""[22] Ремонт х6 мес."",
        ""price"": 600,
        ""speed"": 50,
        ""amigo"": 1,
        ""del"": 0
    },
    ""141"": {
        ""title"": ""[22] 400-пятьдесят"",
        ""price"": 400,
        ""speed"": 50,
        ""amigo"": 0,
        ""del"": 0
    },
    ""140"": {
        ""title"": ""[22] 900-пятьсот"",
        ""price"": 900,
        ""speed"": 500,
        ""amigo"": 1,
        ""del"": 0
    },
    ""139"": {
        ""title"": ""[22] 600-двести"",
        ""price"": 600,
        ""speed"": 200,
        ""amigo"": 1,
        ""del"": 0
    },
    ""138"": {
        ""title"": ""[22] 550-сто"",
        ""price"": 550,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""137"": {
        ""title"": ""[22] 450-шестьдесятПять"",
        ""price"": 450,
        ""speed"": 65,
        ""amigo"": 1,
        ""del"": 0
    },
    ""125"": {
        ""title"": ""flash"",
        ""price"": 0,
        ""speed"": 1000,
        ""amigo"": 1,
        ""del"": 0
    },
    ""134"": {
        ""title"": ""Успешный-100"",
        ""price"": 2000,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""133"": {
        ""title"": ""400-любимый"",
        ""price"": 400,
        ""speed"": 75,
        ""amigo"": 1,
        ""del"": 0
    },
    ""128"": {
        ""title"": ""550+тв"",
        ""price"": 550,
        ""speed"": 70,
        ""amigo"": 1,
        ""del"": 0
    },
    ""123"": {
        ""title"": ""550-любимый"",
        ""price"": 550,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""122"": {
        ""title"": ""999-пятьсот"",
        ""price"": 999,
        ""speed"": 500,
        ""amigo"": 1,
        ""del"": 0
    },
    ""121"": {
        ""title"": ""800-двести"",
        ""price"": 800,
        ""speed"": 200,
        ""amigo"": 1,
        ""del"": 0
    },
    ""120"": {
        ""title"": ""600-сто"",
        ""price"": 600,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    },
    ""119"": {
        ""title"": ""400-пятьдесят"",
        ""price"": 400,
        ""speed"": 50,
        ""amigo"": 1,
        ""del"": 0
    },
    ""0"": {
        ""title"": ""— специальный —"",
        ""price"": 1,
        ""speed"": 0,
        ""amigo"": 0,
        ""del"": 0
    },
    ""70"": {
        ""title"": ""дети"",
        ""price"": 0,
        ""speed"": 35,
        ""amigo"": 1,
        ""del"": 0
    },
    ""66"": {
        ""title"": ""Успешный-40 (Рынок)"",
        ""price"": 1000,
        ""speed"": 40,
        ""amigo"": 1,
        ""del"": 0
    },
    ""98"": {
        ""title"": ""zebra"",
        ""price"": 0,
        ""speed"": 10,
        ""amigo"": 1,
        ""del"": 0
    },
    ""11"": {
        ""title"": ""amigo"",
        ""price"": 0,
        ""speed"": 100,
        ""amigo"": 1,
        ""del"": 0
    }
}

";
        }

        public string User()
        {
            return @"{
                ""UserInfo"":   [{ ""Login"": [ ""u007"" ]}],
                ""UserSms"":    [{ ""Phone"": [ ""9160001122"" ]}],              
                ""PagePay"":    [{ ""Balance"": [ 1567.28 ]}],
                ""PagePrice"":  [{ ""Price"": [ ""123"" ] }],
                ""UserHold"":   [{ ""Hold"": [ ""0""] }],
                ""UserTv"":     [{ ""Tv"": [1, 2, 3] }],
                ""UserCredit"": [{ ""Credit"": [ 123.02 ]}],
                ""UserService"":[{ ""Service"": [ 79 ]}],
                ""a"":          [{ ""Ip"": [ ""2a06:4180:1:0:0:0:0:5a6"", ""10.184.10.1"" ]}, {""noLink"": [1]}]
            }";
        }
    }
}