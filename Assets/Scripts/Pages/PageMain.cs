using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pages
{
    public class PageMain : MonoBehaviour
    {
        [SerializeField] private GameObject _prefabButton, _prefabDouble;
        [SerializeField] private Transform _golfCourse;
        public PageMain() { }

        public void Init()
        {
            Clear(_golfCourse);
            Attach(_golfCourse);
            Debug.Log("PageMain.Init()");
        }

        private void Attach(Transform transform)
        {
            string word;
            var prefab = _prefabButton;
            for (int i = 0; i < 10; i++)
            {
                word = $"button_{i}";
                GameObject instance = Object.Instantiate(prefab);
                instance.transform.SetParent(transform, false);
                instance.SetName(word);
            }
        }

        private void Clear(Transform transform)
        {
            foreach (Transform child in transform) Destroy(child.gameObject);

        }
    }
}


public static partial class Utilites
{
    public static GameObject SetName(this GameObject gameObject, string name)
    {
        gameObject.name = name;
        return gameObject;
    }
}