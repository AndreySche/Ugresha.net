using System.Collections.Generic;
using UnityEngine;

namespace Ugresha
{
    public class PageCreator
    {
        private Transform _contentTarget;
        private GameObject _buttonCollection;
        private AppController _appController;
        private ButtonFactory _buttonFactory;

        public PageCreator(Transform contentTarget, ref GameObject buttonCollection)
        {
            _contentTarget = contentTarget;
            _buttonCollection = buttonCollection;
            _buttonFactory = new ButtonFactory(ref buttonCollection);
            _appController = new AppController(this);
            _appController.PreLoader(Page.PageMain);
        }

        public void SetContent(Page page, VnuBase vnuBase)
        {
            _contentTarget.Destroy();
            var buttonList = _buttonFactory.CreateButtons(_contentTarget, page, vnuBase);
        }
    }
}
