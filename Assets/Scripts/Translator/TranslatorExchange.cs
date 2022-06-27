using System;
using System.Collections.Generic;

namespace Ugresha
{
    public class TranslatorExchange
    {
        private Dictionary<string, string> _dictTitles;
        public TranslatorExchange(Lang lang) => _dictTitles = SetDictTitles(lang);
        public string TitleExchange(string name) => _dictTitles.ContainsKey(name) ? _dictTitles[name] : name;
        private string Float(string a) => double.Parse(a).ToString("0,0.##");
        private string Phone(string a) => String.Format(@"+7 {0:(###) ###-##-##}", double.Parse(a));
        private string Credit(string a, string rub) => double.Parse(a) > 0 ? $"{Float(a)}{rub}" : "отключен";
        internal string DescExchange(VnuInfo info, VnuBase vnuBase)
        {
            string rub = "₽";
            List<string> newString = new List<string>();
            foreach (var description in info.Description)
            {
                switch (info.Title)
                {
                    case "phone": newString.Add($"{Phone(description)}"); break;
                    case "balance": newString.Add($"{Float(description)}{rub}"); break;
                    case "credit": newString.Add($"{Credit(description, rub)}"); break;
                    case "hold": newString.Add($"{Hold(int.Parse(description))}"); break;
                    default: newString.Add(description); break;
                }
            }
            return string.Join("\n", newString);
        }

        private class HoldTitles { public string Class; public string Title; }
        private string Hold(int status)
        {
            Dictionary<int, HoldTitles> list = new Dictionary<int, HoldTitles>()
            {
                { 0, new HoldTitles() { Class = "grey", Title = "отсутствует" } },
                { 1, new HoldTitles() { Class = "red", Title = "системная" } },
                { 2, new HoldTitles() { Class = "red", Title = "административная" } },
                { 3, new HoldTitles() { Class = "green", Title = "добровольная" } }
             };

            if (!list.ContainsKey(status))
                list.Add(status,  new HoldTitles() { Class = "red", Title = $"code: {status.ToString()}" });

            return $"<color=\"{list[status].Class}\">{list[status].Title}</color>";
        }

        private Dictionary<string, string> SetDictTitles(Lang lang)
        {
            return new Dictionary<string, string>() {
                { "login", "логин" },
                { "phone", "телефон для sms" },
                { "balance", "баланс" },
                { "price", "тариф" },
                { "hold", "блокировка" },
                { "tv", "смотрешка тв" },
                { "credit", "обещанный платеж" },
                { "service", "доп.услуги" },
                { "ip", "ip адрес" }
            };
        }
    }
}