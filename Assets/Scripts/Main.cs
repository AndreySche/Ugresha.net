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
        private SafeArea _safeArea;
        static public Theme ThemeBackground;

        void Awake()
        {
            _safeArea = new SafeArea(_workArea.GetComponent<RectTransform>());
            //Curtain curtain = new Curtain(_canvas);

            ThemeBackground = new Theme(_backgoundImage);
            ThemeBackground.SetThemeBlack(true);

            new AppController(_contentTarget, _workArea, ref _buttonCollection);
        }

        void Update()
        {
            _safeArea.Update();
        }
    }
}