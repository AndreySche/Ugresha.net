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

    public static GameObject AddClick(this GameObject gameObject, string name)
    {
        gameObject.GetOrAddComponent<Button>().onClick.AddListener(() => Debug.Log(name));
        return gameObject;
    }

    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var result = gameObject.GetComponent<T>();
        if (!result)
        {
            result = gameObject.AddComponent<T>();
        }

        return result;
    }

    public static string RectToString(this RectTransform rect) // Не удалять
    {
        return $"anchorMin|Max\n" +
            $"new Vector({rect.anchorMin.x}, {rect.anchorMin.y})\n" +
            $"new Vector({rect.anchorMax.x}, {rect.anchorMax.y})\n\n" +

            "pivot\n" +
            $"new Vector({rect.pivot.x}, {rect.pivot.y})" +
            "anchoredPosition\n" +
            $"new Vector({rect.anchoredPosition.x}, {rect.anchoredPosition.y})\n\n" +

            "anchorMin|Max\n" +
            $"new Vector({rect.offsetMin.x}, {rect.offsetMin.y})\n" +
            $"new Vector({rect.offsetMax.x}, {rect.offsetMax.y})";
    }
}