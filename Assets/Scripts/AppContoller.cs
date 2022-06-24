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
            Load(page);
        }

        public void Load(Page page)
        {
            if (_actualPage == page) return;

            _actualPage = page;
            PageMain pageMain = EasyLoad<PageMain>("PageMain");
            pageMain.Init();
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
