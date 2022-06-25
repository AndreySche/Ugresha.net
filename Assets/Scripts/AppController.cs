using UnityEngine;
using System.Collections.Generic;

namespace Ugresha
{
    public class AppController
    {
        private Page _actualPage;
        private Transform _contentTarget;
        private Authorization _authorization;
        private PageCreator _pageCreator;

        public AppController(Transform contentTarget, Transform workArea, ref GameObject buttonCollection)
        {
            _contentTarget = contentTarget;
            _authorization = new Authorization();
            _pageCreator = new PageCreator(_contentTarget, buttonCollection);
            MenuDown menuDown = new MenuDown(workArea);
            SwitchPage(Page.PageMain);
        }

        public void SwitchPage(Page page)
        {
            if (_actualPage == page) return; //Debug.Log($"{_actualPage} => {page}");

            UserAuth userAuth = _authorization.VerifyAuth();
            if (userAuth.Aid <= 0) page = Page.PageAuth;

            var server = new GetServerData();
            var pageContent = server.Get(userAuth, Page.PageMain);

            SwitchPageAfter(page, pageContent); // todo
        }

        public void SwitchPageAfter(Page page, List<PageContent> pageContent)
        { 
            _actualPage = page;
            _contentTarget.Destroy();
            _pageCreator.SetData(pageContent);
        }

        /*public void Load(Page page)
        {
            if (_actualPage == page) return; //Debug.Log($"{_actualPage} => {page}");

            _actualPage = page;
            _pageArea.Destroy();
            switch (page)
            {
                case Page.PageAuth:
                    PageAuth pageAuth = EasyLoad<PageAuth>("PageAuth");
                    pageAuth.Init(); break;
                case Page.PageMain:
                    PageMain pageMain = EasyLoad<PageMain>("PageMain");
                    pageMain.Init(this); break;
                default:
                    PageError pageError = EasyLoad<PageError>("PageError");
                    pageError.Init(); break;
            }
        }

        private T EasyLoad<T>(string file) where T : Component
        {
            return ResourceLoader.LoadAndInstantiateObject<T>(
                new ResourcePath { PathResource = "Pages/" + file }, _pageArea, false
            );
        }*/
    }
}
