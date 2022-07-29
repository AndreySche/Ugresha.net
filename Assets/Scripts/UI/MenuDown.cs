using System.Collections.Generic;
using UnityEngine;

namespace Ugresha
{    public class MenuDown
    {
        public MenuDown(Transform target, ref GameObject buttonCollection)
        {
            var newObject = target.AddRectTransform(RectData(), "MenuDown");
            //Debug.Log(newObject.Box.RectToString());
        }

        private RectDictionary RectData()
        {
            return new RectDictionary()
            {
                //color = new Color(0, 0, 0, 0.5f),
                color = new Color(100 / 255f, 100 / 255f, 100 / 255f, 0.5f), // tmp
                points = new Dictionary<string, List<float>>
                {
                    { "anchorMax", new List<float>{ 1, 0 }},
                    { "anchorMin", new List<float>{ 0, 0 }},
                    { "pivot", new List<float>{ 0.5f, 0 }},
                    { "anchoredPosition", new List<float>{ 0, 0 }},
                    { "offsetMax", new List<float>{ 0, 200 }},
                    { "offsetMin", new List<float>{ 0, -50 }}
                }
            };
        }
    }
}