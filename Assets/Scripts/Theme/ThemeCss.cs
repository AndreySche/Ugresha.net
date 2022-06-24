using System;
using System.Collections.Generic;
using UnityEngine;


namespace Ugresha
{
    static class ThemeCss
    {
        static private Dictionary<string, Color> _styles;

        static public Color GetColor(string index)
        {
            _styles = Library();
            var res = _styles.TryGetValue(index, out var value) ? value : _styles["white"];
            return res;
        }

        static private Dictionary<string, Color> Library()
        {
            if (_styles != null) return _styles;

            _styles = new Dictionary<string, Color>(){
                { "white", new Color(1f, 1f, 1f, 1f) },
                { "whiteAlpha", new Color(1f, 1f, 1f, 0.15f) },
                { "black", new Color(0, 0, 0, 1f) },
                { "grey", new Color(100/255f, 100/255f, 100/255f, 1f) },
                { "darkBlue", new Color(12/255f, 15/255f, 24/255f, 1f) }
            };
            return _styles;
        }
    }
}