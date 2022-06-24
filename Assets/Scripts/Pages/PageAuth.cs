using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class PageAuth : MonoBehaviour, IDisposable
    {
        public List<Image> ButtonList;
        private List<Theme> _themeList;

        public void Init()
        {
            _themeList = new List<Theme>();
            foreach (Image button in ButtonList)
            {
                var a = new Theme(button);
                Main.ThemeBackground.AddText(a);
                _themeList.Add(a);
            }
        }

        public void Dispose()
        {
            foreach (Theme button in _themeList)
            {
                Main.ThemeBackground.DelText(button);
            }
            _themeList.Clear();
            Debug.Log("Disposable");
        }
    }
}
