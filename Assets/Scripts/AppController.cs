using UnityEngine;
using System.Collections.Generic;

namespace Ugresha
{
    public class AppController
    {
        private Page _actualPage;
        private Authorization _authorization;
        private PageCreator _pageCreator;
        private ServerRequest _server;

        public AppController(PageCreator pageCreator)
        {
            _pageCreator = pageCreator;
            _server = new ServerRequest();
            _authorization = new Authorization();
        }

        public void PreLoader(Page page)
        {
            if (_actualPage == page) return; //Debug.Log($"{_actualPage} => {page}");

            UserAuth userAuth = _authorization.VerifyAuth();
            if (userAuth.Guest) page = Page.PageAuth;

            VnuBase vnuBase = _server.Get(userAuth, page);
            //var pageContent = _server.Get(userAuth, page);
            AfterLoader(page, vnuBase); // todo preloader view
        }

        public void AfterLoader(Page page, VnuBase vnuBase)
        { 
            _actualPage = page;
            _pageCreator.SetContent(page, vnuBase);
        }
    }
}
