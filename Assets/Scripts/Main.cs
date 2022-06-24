using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private GameObject _SafeAreaGB, _curtain;
        [SerializeField] private Transform _loadTarget;
        [SerializeField] private Image _backgoundImage;
        private AppContoller _appController;
        private SafeArea _safeArea;

        static public Theme ThemeBackground;

        void Awake()
        {
            _safeArea = new SafeArea(_SafeAreaGB.GetComponent<RectTransform>());
            ThemeBackground = new Theme(_backgoundImage);
            ThemeBackground.ChangeTheme(true);

            _appController = new AppContoller();
            _appController.Init(_loadTarget, Page.PageMain);
        }

        void Update()
        {
            _safeArea.Update();
        }
    }
}