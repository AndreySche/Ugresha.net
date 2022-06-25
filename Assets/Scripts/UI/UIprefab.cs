using UnityEngine;

namespace Ugresha 
{
    class UIprefab : MonoBehaviour
    {
        public GameObject PrefabButton, PrefabInfoButton;

        public void SetInfo(PageContent info)
        {
            var res = transform.Attach(info.Title, PrefabInfoButton);
            res.GetComponent<UIbuttonOne>().Title.text = $"{info.Title}:";
            res.GetComponent<UIbuttonOne>().Description.text = info.Description;
            res.GetComponent<UIbuttonOne>().Link = info.Link;

            if (info.Link == Page.UserNull) return;
            //res.GetOrAddComponent<Button>().onClick.AddListener(() => appController.Load(info.Link));
        }
    }
}