using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Ugresha
{
    internal sealed class ButtonFactory
    {
        private GameObject _buttonCollection;
        private TranslatorExchange _translator;
        public ButtonFactory(ref GameObject buttonCollection)
        {
            _buttonCollection = buttonCollection;
            _translator = new TranslatorExchange(Lang.Rus);
        }

        public List<GameObject> CreateList(Transform contentTarget, VnuBase vnuBase)
        {
            GameObject prefab = _buttonCollection.GetComponentInChildren<UIprefab>().PrefabInfoButton; // костыль
            List<GameObject> buttonList = new List<GameObject>();
            foreach (VnuList line in vnuBase.UserInfo)
            {
                string title = _translator.TitleExchange(line.Info.Title);
                string description = _translator.DescExchange(line.Info, vnuBase);

                var res = contentTarget.Attach(line.Name, prefab);
                buttonList.Add(res);
                res.GetComponent<UIbuttonOne>().Title.text = $"{title}:";
                res.GetComponent<UIbuttonOne>().Description.text = $"{description}";
                //res.GetComponent<UIbuttonOne>().Link = line.Link;

                //if (button.Link == Page.UserNull) continue;
                //res.GetOrAddComponent<Button>().onClick.AddListener(() => appController.Load(info.Link));
            }
            return buttonList;
        }
    }
}