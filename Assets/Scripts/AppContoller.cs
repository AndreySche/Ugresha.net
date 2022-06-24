using UnityEngine;

namespace Ugresha
{
    class AppContoller
    {
        public AppContoller() { }

        public void Load(Pages.Pages page)
        {
            Debug.Log($"Load page => {page}");
        }
    }
}
