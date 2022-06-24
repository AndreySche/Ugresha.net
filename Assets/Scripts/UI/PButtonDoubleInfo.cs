using UnityEngine.UI;

public class PButtonDoubleInfo : PButtonMultiline
{
    public Text Title;

    public PButtonDoubleInfo() { }

    public PButtonDoubleInfo(string text, string title) { Text.text = text; Title.text = title; }
}
