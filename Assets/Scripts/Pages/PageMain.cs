using System.Collections.Generic;
using UnityEngine;
using Ugresha;

namespace Pages
{
    public class PageMain : MonoBehaviour
    {
        [SerializeField] private GameObject _UIbutton;
        [SerializeField] private Transform _golfCourse;
        private AppController _appController;

        private List<VnuMenu> _data;
        public PageMain() { }

        public void Init(AppController appController)
        {
            _appController = appController;
            _data = PushData();
            _golfCourse.Destroy();
            Attach(_golfCourse, _data);
        }

        private void Attach(Transform transform, List<VnuMenu> list)
        {
            string title;
            foreach(var button in list)
            {
                title = button.Title;
                var res = transform.Attach(title, _UIbutton);
                res.GetComponent<UIprefab>().SetInfo(button, _appController);
            }
        }

        private List<VnuMenu> PushData() // ToDo: Pull From Server
        {
            var list = new List<VnuMenu>();
            list.Add(new VnuMenu($"логин", "u8986", Page.UserInfo));
            list.Add(new VnuMenu($"телефон для sms", "+7 (016) 502-20-21", Page.UserSms));
            list.Add(new VnuMenu($"баланс", "1 567.28₽", Page.PagePay));
            list.Add(new VnuMenu($"тариф", "400 - пятьдесят", Page.PagePrice));
            list.Add(new VnuMenu($"блокировка", "отсутствует", Page.UserHold));
            list.Add(new VnuMenu($"смотрешка тв", "Эксклюзив + PREMIER\nМАТЧ! Премьер HD\nМатч! Футбол", Page.UserTv));
            list.Add(new VnuMenu($"обещанный платеж", "отключен", Page.UserCredit));
            list.Add(new VnuMenu($"ip адрес", "2a06:4180:1:0:0:0:0:428\n10.184.10.1", Page.UserNull));
            return list;
        }
    }
}