using UnityEngine;
using UnityEngine.UI;

public static partial class Utilites
{
    public static GameObject AddRectTransform(this Transform target, RectDictionary data, string name)
    {
        var empty = new GameObject();
        GameObject gameObject = target.Attach(name, empty);
        var Box = gameObject.GetOrAddComponent<RectTransform>();
        var image = gameObject.GetOrAddComponent<Image>();
        image.color = data.color != null ? data.color : new Color(0, 0, 0, 0.5f);
        Object.Destroy(empty);

        // Важен порядок присвоения
        Box.anchorMin = GetVector(ref data, "anchorMin");
        Box.anchorMax = GetVector(ref data, "anchorMax");

        Box.pivot = GetVector(ref data, "pivot");
        Box.anchoredPosition = GetVector(ref data, "anchoredPosition");

        Box.offsetMin = GetVector(ref data, "offsetMin");
        Box.offsetMax = GetVector(ref data, "offsetMax");
        return gameObject;


    }

    static private Vector2 GetVector(ref RectDictionary data, string name) => new Vector2(data.points[name][0], data.points[name][1]);
}
