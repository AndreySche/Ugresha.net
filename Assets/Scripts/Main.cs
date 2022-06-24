using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private GameObject Canvas;
        [SerializeField] private Image BackgroundImage;
        static public Theme ThemeBackground;
        private SafeArea _safeArea;
        private AppContoller appController;

        void Awake()
        {
            _safeArea = new SafeArea(Canvas.GetComponent<RectTransform>());
            ThemeBackground = new Theme(BackgroundImage);
            ThemeBackground.ChangeTheme(true);

            appController = new AppContoller();
            //appController.Init(Pages.Auth);
        }

        void Update()
        {
            _safeArea.Update();
        }
    }
}