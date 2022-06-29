using UnityEngine;

class SafeArea // DeviceSimulator 2.3 !!!
{    
    private Rect LastSafeArea;
    private RectTransform Panel;
    public void Update() => Refresh(Screen.safeArea);

    public SafeArea(RectTransform panel)
    {
        Panel = panel;
        LastSafeArea = new Rect(0, 0, 0, 0);
        Application.targetFrameRate = 120;
        Refresh(Screen.safeArea);
    }

    private void Refresh(Rect r)
    {
        if (r == LastSafeArea) return;

        LastSafeArea = r;
        Vector2 anchorMin = r.position;
        //anchorMin.y *= 1.6f; // небольшое наступание на safeArea UP
        Vector2 anchorMax = anchorMin + r.size;
        //anchorMin.y *= 0.3f; // небольшое наступание на safeArea Down

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        Panel.anchorMin = anchorMin;
        Panel.anchorMax = anchorMax;

        //Debug.LogFormat($"New safe area applied: x={r.x}, y={r.y}, w={r.width}, h={r.height} on full extents w={Screen.width}, h={Screen.height}");
    }
}
