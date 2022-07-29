using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ServiceArea", menuName = "Add Info")]
public class LoadTarget : ScriptableObject
{
    [SerializeField] private GameObject PrefabButtons;
}