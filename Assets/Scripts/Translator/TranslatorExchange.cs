using System.Collections.Generic;

namespace Ugresha
{
    public class TranslatorExchange
    {
        private Dictionary<string, string> _dictionary;
        public TranslatorExchange(Lang lang)
        {
            _dictionary = SetDictionary(lang);
        }

        public string TitleExchange(string name) => _dictionary.ContainsKey(name) ? _dictionary[name] : name;

        private Dictionary<string, string> SetDictionary(Lang lang)
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