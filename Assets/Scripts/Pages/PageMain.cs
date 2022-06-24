using System.Collections.Generic;
using UnityEngine;

namespace Pages
{
    public class PageMain : MonoBehaviour
    {
        [SerializeField] private GameObject _prefabButton, _prefabDouble;
        [SerializeField] private Transform _golfCourse;

        private List<VnuMenu> _data;
        public PageMain() { }

        public void Init()
        {
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
                var res = transform.Attach(title, _prefabButton);
            }
        }

        private List<VnuMenu> PushData() // tmp : todo Pull From Server
        {
            var list = new List<VnuMenu>();
            for (int i = 0; i < 10; ++i) list.Add(new VnuMenu($"title {i}", "description {i}", "link {i}"));
            return list;
        }
    }
}