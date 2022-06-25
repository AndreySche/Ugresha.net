﻿using System.Collections.Generic;
using UnityEngine;

namespace Ugresha
{
    public class Curtain
    {
        public Curtain(Transform target)
        {
            var newObject = new AddRectTransform(target, SetData(), "Curtain");
            //Debug.Log(newObject.Box.RectToString());
        }

        private RectDictionary SetData()
        {
            return new RectDictionary()
            {
                color = new Color(0, 0, 0, 1),
                points = new Dictionary<string, List<float>>
                {
                    { "offsetMin", new List<float>{ 0, 0 }},
                    { "offsetMax", new List<float>{ 0, 0 }},
                    { "anchorMin", new List<float>{ 0, 0 }},
                    { "anchorMax", new List<float>{ 1, 1 }},
                    { "anchoredPosition", new List<float>{ 0, 0 }},
                    { "pivot", new List<float>{ 0.5f, 0.5f }},
                }
            };
        }
    }
}