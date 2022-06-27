using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform _canvas;
        [SerializeField] private Image _backgoundImage;
        [SerializeField] private Transform _workArea, _contentTarget;
        [SerializeField] private GameObject _buttonCollection;

        static public Theme ThemeBackground;
        private SafeArea _safeArea;

        void Awake()
        {
            _safeArea = new SafeArea(_workArea.GetComponent<RectTransform>());
            Curtain curtain = new Curtain(_canvas); // for preloader
            var menu = new MenuDown(_workArea, ref _buttonCollection);

            ThemeBackground = new Theme(_backgoundImage);
            ThemeBackground.SetThemeBlack(true);

            new PageCreator(_contentTarget, ref _buttonCollection);
        }

        void Update()
        {
            _safeArea.Update();
        }
    }
}