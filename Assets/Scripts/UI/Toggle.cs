using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Ugresha
{
    public class Toggle : MonoBehaviour
    {
        public Text Text;
        public Main main;

        private bool ThemeDark;
        private Button _button;
        private ColorBlock _color;

        private void Start()
        {
            ThemeDark = true;
            _button = GetComponent<Button>();
            SetColor(ThemeDark);
        }

        public void MyClick()
        {
            ThemeDark = !ThemeDark;
            SetColor(ThemeDark);
            //Main.ThemeBackground.SetThemeBlack(ThemeDark);
        }

        private void SetColor(bool dark)
        {
            Text.text = dark ? "темная тема" : "светлая тема";
            var select = ThemeCss.GetColor(dark ? "grey" : "grey");

            Text.color = select;
            _color = _button.colors;
            _color.normalColor = select;
            _color.highlightedColor = select;
            _color.pressedColor = select;
            _color.selectedColor = select;
            _color.disabledColor = select;
            _button.colors = _color;
        }
    }
}
