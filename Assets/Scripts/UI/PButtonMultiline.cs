using UnityEngine;
using UnityEngine.UI;

public class PButtonMultiline : MonoBehaviour
{
    public Text Text;
    public Image border;

    public PButtonMultiline() { }

    public PButtonMultiline(string text) { Text.text = text; }
}
