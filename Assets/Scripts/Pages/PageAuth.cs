using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pages
{
    public class PageAuth : MonoBehaviour/*, IDisposable*/
    {
        public List<Image> ButtonList;
        //private List<Theme> _themeList;

        /*public void Init()
        {
            _themeList = new List<Theme>();
            foreach (Image button in ButtonList)
            {
                var a = new Theme(button);
                PageMain.ThemeBackground.AddText(a);
                _themeList.Add(a);
            }
        }

        public void Dispose()
        {
            foreach (Theme button in _themeList)
            {
                PageMain.ThemeBackground.DelText(button);
            }
            _themeList.Clear();
            Debug.Log("Disposable");
        }*/
    }
}
