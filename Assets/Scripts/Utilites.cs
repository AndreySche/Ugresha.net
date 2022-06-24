using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static partial class Utilites
{

    public static Transform Destroy(this Transform transform)
    {
        foreach (Transform child in transform) Object.Destroy(child.gameObject);
        return transform;
    }

    public static GameObject SetName(this GameObject gameObject, string name)
    {
        gameObject.name = name;
        return gameObject;
    }
    public static GameObject Attach(this Transform transform, string word, GameObject prefab)
    {
        {
            GameObject instance = Object.Instantiate(prefab);
            instance.transform.SetParent(transform, false);
            //instance.SetName(word).SetTextInChildren(word);
            instance.SetName(word);
            return instance;
        }
    }
}