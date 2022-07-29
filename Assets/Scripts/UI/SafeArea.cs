using UnityEngine;

class SafeArea : IUpdatable// onli DeviceSimulator 2.3 !!!
{
    private Rect _lastSafeArea;
    private RectTransform _panel;
    public Vector2 anchorMin { get; private set; }
    public void Update() => Refresh(Screen.safeArea);

    public SafeArea(RectTransform panel)
    {
        _panel = panel;
        _lastSafeArea = new Rect(0, 0, 0, 0);
        Application.targetFrameRate = 120;
        Refresh(Screen.safeArea);
    }

    private void Refresh(Rect safeArea)
    {
        if (safeArea == _lastSafeArea) return;

        _lastSafeArea = safeArea;
        Vector2 anchorMin = safeArea.position; // нижний отступ
        Vector2 anchorMax = anchorMin + safeArea.size; // верхний отступ
        //anchorMin = new Vector2(0, 0); // убрать отступ
        anchorMin /= 2;

        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;
        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;

        _panel.anchorMin = anchorMin;
        _panel.anchorMax = anchorMax;

        //Debug.LogFormat($"SafeArea: x={safeArea.x}, y={safeArea.y}, w={safeArea.width}, h={safeArea.height} on full extents w={Screen.width}, h={Screen.height}, tmp={tmp}");
    }
}
