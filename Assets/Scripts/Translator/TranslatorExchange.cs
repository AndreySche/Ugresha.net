using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ugresha
{
    public class TranslatorExchange
    {
        private Dictionary<string, string> _dictTitles;
        public TranslatorExchange(Lang lang) => _dictTitles = SetDictTitles(lang);
        public string TitleExchange(string name) => _dictTitles.ContainsKey(name) ? _dictTitles[name] : name;
        private string Float(string a) => double.Parse(a, CultureInfo.InvariantCulture).ToString("#,0.##");
        private string Phone(string a) => String.Format(@"+7 {0:(###) ###-##-##}", double.Parse(a));
        private string Credit(string a, string rub) => double.Parse(a, CultureInfo.InvariantCulture) > 0 ? $"{Float(a)}{rub}" : "отключен";
        private string Price(int a, VnuBase vnuBase) =>
            vnuBase.Price.ContainsKey(a) ? vnuBase.Price[a].Title : a.ToString();

        internal string DescExchange(string key, List<string> list, VnuBase vnuBase)
        {
            string rub = "₽";
            List<string> newString = new List<string>();
            foreach (var text in list)
            { 
                switch (key)
                {
                    case "Phone": newString.Add($"{Phone(text)}"); break;
                    case "Balance": newString.Add($"{Float(text)}{rub}"); break;
                    case "Credit": newString.Add($"{Credit(text, rub)}"); break;
                    case "Hold": newString.Add($"{Hold(int.Parse(text))}"); break;
                    case "Price": newString.Add($"{Price(int.Parse(text), vnuBase)}"); break;
                    default: newString.Add(text); break;
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
                list.Add(status, new HoldTitles() { Class = "red", Title = $"code: {status.ToString()}" });

            return $"<color=\"{list[status].Class}\">{list[status].Title}</color>";
        }

        private Dictionary<string, string> SetDictTitles(Lang lang)
        {
            return new Dictionary<string, string>() {
                { "Login", "логин" },
                { "Phone", "телефон для sms" },
                { "Balance", "баланс" },
                { "Price", "тариф" },
                { "Hold", "блокировка" },
                { "Tv", "смотрешка тв" },
                { "Credit", "обещанный платеж" },
                { "Service", "доп.услуги" },
                { "Ip", "ip адрес" }
            };
        }
    }
}