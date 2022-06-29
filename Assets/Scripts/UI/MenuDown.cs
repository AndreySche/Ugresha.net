using System.Collections.Generic;
using UnityEngine;

namespace Ugresha
{    public class MenuDown
    {
        public MenuDown(Transform target, ref GameObject buttonCollection)
        {
            var newObject = target.AddRectTransform(SetData(), "MenuDown");
            //Debug.Log(newObject.Box.RectToString());
        }

        private RectDictionary SetData()
        {
            return new RectDictionary()
            {
                color = new Color(0, 0, 0, 0.5f),
                points = new Dictionary<string, List<float>>
                {
                    { "anchorMin", new List<float>{ 0, 0 }},
                    { "anchorMax", new List<float>{ 1, 0 }},
                    { "pivot", new List<float>{ 0.5f, 0 }},
                    { "anchoredPosition", new List<float>{ 0, 0 }},
                    { "offsetMin", new List<float>{ 0, -100 }},
                    { "offsetMax", new List<float>{ 0, 250 }},
                }
            };
        }
    }
}