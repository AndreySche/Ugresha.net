using System;
using UnityEngine;

public class MyGui : MonoBehaviour
{
    void OnGUI()
    {
        int width = 200;
        int height = 150;
        GUI.Box(new Rect(Screen.width / 2 - width / 2, Screen.height / 2 - height / 2, width, height), "Main menu");

        RenderButton(width, height, 0, "Open");
        RenderButton(width, height, 1, "Save");
        RenderButton(width, height, 2, "Load");
    }

    private void RenderButton(int width, int height, int count, string title)
    {
        int w = width - 20;
        int h = 30;
        int step = Screen.height / 2 - height /2 + (h + 5) * (count + 1);
        GUI.Button(new Rect(Screen.width / 2 - w / 2, step, w, h), title);
    }
}
