using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    internal class ServiceArea
    {
        private MenuDown _menu;
        private PageCreator _generator;
        private Theme _themeBackground;

        public ServiceArea(Transform canvas, Image backgroundImage, Transform scrollArea, Transform staticArea, GameObject buttonCollection)
        {
            // создаем нижнее меню
            _menu = new MenuDown(staticArea, ref buttonCollection);

            // создаем шторку для прелоадера : порядок важен, закрывает menuDown
            Curtain curtain = new Curtain(canvas);

            _themeBackground = new Theme(backgroundImage);
            _themeBackground.SetThemeBlack(true);

            // генерируем страницу
            _generator = new PageCreator(scrollArea, ref buttonCollection);
        }
    }
}