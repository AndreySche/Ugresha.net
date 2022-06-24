using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private GameObject _SafeAreaGB, _curtain, _menu;
        [SerializeField] private Transform _loadTarget;
        [SerializeField] private Image _backgoundImage;
        [SerializeField] private Menu _menuDown;
        private AppController _appController;
        private SafeArea _safeArea;

        static public Theme ThemeBackground;

        void Awake()
        {
            _safeArea = new SafeArea(_SafeAreaGB.GetComponent<RectTransform>());
            ThemeBackground = new Theme(_backgoundImage);
            ThemeBackground.ChangeTheme(true);

            _appController = new AppController(_loadTarget, Page.PageAuth);
            _menuDown.Init(_appController);
        }

        void Update()
        {
            _safeArea.Update();
        }
    }
}