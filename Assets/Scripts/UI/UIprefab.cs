using UnityEngine;

namespace Ugresha
{
    class UIprefab : MonoBehaviour
    {
        public GameObject PrefabButton, PrefabButtonInfo, PrefabButtonMenu;

        public GameObject Get(string name)
        {
            switch (name)
            {
                case "info": return PrefabButtonInfo;
                case "menu": return PrefabButtonMenu;
            }
            return PrefabButton;
        }

    }
}