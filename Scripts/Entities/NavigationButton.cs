using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PedroBelluzzo.UnityMenuNavigation
{
    [RequireComponent(typeof(Button))]

    public class NavigationButton : MonoBehaviour
    {
        [SerializeField] private MenuScreen _menuScreen;

        private Button _button;

        public MenuScreen MenuScreen { get => _menuScreen; set => _menuScreen = value; }

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(NavigateToScreen);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(NavigateToScreen);
        }

        private void NavigateToScreen() 
        {
            if (_menuScreen == null) 
            {
                MenuSystemDebugger.DebugLog("Navigation Failed. Variable _menuScreen is not set.", gameObject);
                return;
            }

            UINavigationManager.Instance.NavigateTo(_menuScreen);
        }
    }

}
