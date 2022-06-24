using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Ugresha
{
    public class Theme
    {
        private event Action<bool> Viewers;
        private Image Object;
        //private Color _color;

        public Theme() { }
        public Theme(Image obj) => Object = obj;

        //public void Add(Theme viewer, bool a, MyFunc act) => Viewers += viewer.act(a);

        //public delegate void MyAction(bool a, Theme b);

        //public void Add(bool a, Theme viewer, MyAction act) => act(a, viewer);
        //public void Background(bool a, Theme viewer) => Viewers += viewer.SetImage;


        public void AddBackgrounds(Theme viewer) => Viewers += viewer.SetImage;
        public void AddText(Theme viewer) => Viewers += viewer.SetText;
        public void DelBackgrounds(Theme viewer) => Viewers -= viewer.SetImage;
        public void DelText(Theme viewer) => Viewers -= viewer.SetText;

        /// <summary>
        /// Установить темную тему
        /// </summary>
        /// <param name="dark">ага</param>
        public void ChangeTheme(bool dark)
        {
            string ddark = dark ? "true" : "false";
            SetImage(dark);
            Viewers?.Invoke(dark);
        }

        public void SetImage(bool dark) => Object.color = ThemeCss.GetColor(dark ? "darkBlue" : "whiteAlpha");
        public void SetText(bool dark) => Object.color = ThemeCss.GetColor(!dark ? "darkBlue" : "whiteAlpha");
    }
}
