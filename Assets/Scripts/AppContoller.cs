using UnityEngine;
using Tools;
using Pages;

namespace Ugresha
{
    class AppContoller
    {
        private Transform _loadTarget;
        private Page _actualPage;
        public AppContoller() { }

        public void Init(Transform loadTarget, Page page)
        {
            _loadTarget = loadTarget;
            Load(page);
        }

        public void Load(Page page)
        {
            if (_actualPage == page) return;

            _loadTarget.Destroy();
            _actualPage = page;
            switch (page)
            {
                case Page.PageAuth:
                    PageAuth pageAuth = EasyLoad<PageAuth>("PageAuth");
                    pageAuth.Init(); break;
                default:
                    PageMain pageMain = EasyLoad<PageMain>("PageMain");
                    pageMain.Init(); break;
            }
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
