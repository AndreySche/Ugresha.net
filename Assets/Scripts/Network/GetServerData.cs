using System.Collections.Generic;

namespace Ugresha
{
    internal class GetServerData
    {
        public List<PageContent> Get(UserAuth userAuth, Page page)
        {
            List<PageContent> content = null;
            switch (page)
            {
                case (Page.PageMain): content = PageMainData(); break;

            }
            return content;
        }

        private List<PageContent> PageMainData()
        {
            var list = new List<PageContent>();
            list.Add(new PageContent($"логин", "u8986", Page.UserInfo));
            list.Add(new PageContent($"телефон для sms", "+7 (016) 502-20-21", Page.UserSms));
            list.Add(new PageContent($"баланс", "1 567.28₽", Page.PagePay));
            list.Add(new PageContent($"тариф", "400 - пятьдесят", Page.PagePrice));
            list.Add(new PageContent($"блокировка", "отсутствует", Page.UserHold));
            list.Add(new PageContent($"смотрешка тв", "Эксклюзив + PREMIER\nМАТЧ! Премьер HD\nМатч! Футбол", Page.UserTv));
            list.Add(new PageContent($"обещанный платеж", "отключен", Page.UserCredit));
            list.Add(new PageContent($"ip адрес", "2a06:4180:1:0:0:0:0:428\n10.184.10.1", Page.UserNull));
            return list;
        }

    }
}
