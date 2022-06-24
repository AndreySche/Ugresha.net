using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Menu : MonoBehaviour
    {
        public GameObject Prefab;
        private AppController _appController;

        public void Init(AppController appController)
        {
            _appController = appController;
            transform.Destroy();
            Dictionary<string, Page> list = new Dictionary<string, Page>()
            {
                {"главная", Page.PageMain},
                {"отчеты", Page.PageAuth},
                {"настройки", Page.PageSettings}
            };

            foreach (var info in list)
            {
                GameObject res = transform.Attach(info.Key, Prefab);
                InitButtonMenu(res, info.Value);
            }
        }

        private void InitButtonMenu(GameObject button, Page page)
        {
            button.GetOrAddComponent<Button>().onClick.AddListener(() => _appController.Load(page));
        }
    }
}
