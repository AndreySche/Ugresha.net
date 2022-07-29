using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ugresha
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform _canvas;
        [SerializeField] private Image _backgroundImage;
        [SerializeField] private Transform _scrollArea, _staticArea;
        [SerializeField] private GameObject _buttonCollection;

        private List<IUpdatable> _updatableList = new List<IUpdatable>();

        void Awake()
        {
            Transform target = GetComponent<Transform>();

            // добавляем в IUpdatable => safeArea
            AddUpdatable(new SafeArea(target.GetComponent<RectTransform>()));

            // создаем рабочее поле: curtain, background, scrollarea, menuDown
            ServiceArea serviceArea = new ServiceArea(_canvas, _backgroundImage, _scrollArea, _staticArea, _buttonCollection);
        }

        void Update()
        {
            foreach (var item in _updatableList) item.Update();
        }

        public void AddUpdatable(IUpdatable updatable)
        {
            _updatableList.Add(updatable);
        }
    }
}