using UnityEngine;
using UnityEngine.UI;

namespace Pages {
    class UIprefab : MonoBehaviour
    {
        public GameObject PrefabButton, PrefabInfoButton;

        public void SetInfo(VnuMenu info)
        {
            var res = transform.Attach(info.Title, PrefabInfoButton);
            res.GetComponent<UIbuttonOne>().Title.text = $"{info.Title}:";
            res.GetComponent<UIbuttonOne>().Description.text = info.Description;
            res.GetComponent<UIbuttonOne>().Link = info.Link;
        }
    }
}