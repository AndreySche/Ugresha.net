using System.Collections.Generic;
using UnityEngine;

namespace Ugresha
{
    public class PageCreator
    {
        private Transform _workArea;
        private GameObject _buttonCollection;

        public PageCreator(Transform workArea, GameObject buttonCollection)
        {
            _buttonCollection = buttonCollection;
            _workArea = workArea;
        }

        public void SetData(List<PageContent> list)
        {
            string title;
            foreach (var button in list)
            {
                title = button.Title;
                var res = _workArea.Attach(title, _buttonCollection);
                res.GetComponent<UIprefab>().SetInfo(button);
            }
        }
    }
}
