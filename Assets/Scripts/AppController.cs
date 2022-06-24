using UnityEngine;
using Tools;
using Pages;

namespace Ugresha
{
    public class AppController
    {
        private Transform _loadTarget;
        private Page _actualPage = Page.PageError;

        public AppController(Transform loadTarget, Page page)
        {
            _loadTarget = loadTarget;
            Load(page);
        }

        public void Load(Page page)
        {
            if (_actualPage == page) return;
            Debug.Log($"{_actualPage} => {page}");

            _loadTarget.Destroy();
            switch (page)
            {
                case Page.PageAuth:
                    PageAuth pageAuth = EasyLoad<PageAuth>("PageAuth");
                    pageAuth.Init(); break;
                case Page.PageMain:
                    PageMain pageMain = EasyLoad<PageMain>("PageMain");
                    pageMain.Init(); break;
                default:
                    PageError pageError = EasyLoad<PageError>("PageError");
                    pageError.Init(); break;
            }
            _actualPage = page;
        }

        private T EasyLoad<T>(string file) where T : Component
        {
            return ResourceLoader.LoadAndInstantiateObject<T>(
                new ResourcePath { PathResource = "Pages/" + file },
                _loadTarget, false
            );
        }
    }
}
