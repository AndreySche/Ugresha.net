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

        public List<GameObject> CreateButtons(Transform contentTarget, Page page, VnuBase vnuBase)
        {
            return CreateUserInfo(contentTarget, vnuBase);
        }

        private List<GameObject> CreateUserInfo(Transform contentTarget, VnuBase vnuBase)
        {
            GameObject prefab = _buttonCollection.GetComponentInChildren<UIprefab>().PrefabButtonInfo; // todo
            List<GameObject> buttonList = new List<GameObject>();
            foreach (var line in vnuBase.User)
            {
                var res = contentTarget.Attach(line.Key, prefab);
                buttonList.Add(res);

                var desc = line.Value.First();
                string title = _translator.TitleExchange(line.Value.First().Key);
                string description = _translator.DescExchange(desc.Key, desc.Value, vnuBase);

                res.GetComponent<UIbuttonOne>().Title.text = $"{title}:";
                res.GetComponent<UIbuttonOne>().Description.text = $"{description}";

                //res.GetComponent<UIbuttonOne>().Link = line.Link;

                //if (button.Link == Page.UserNull) continue;
                //res.GetOrAddComponent<Button>().onClick.AddListener(() => appController.Load(info.Link));
            }
            return buttonList; ;
        }
    }
}