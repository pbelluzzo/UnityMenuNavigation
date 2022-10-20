using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PedroBelluzzo.UnityMenuNavigation
{
    public class UINavigationManager : MonoBehaviour
    {
        private static UINavigationManager _instance;

        [SerializeField] private MenuScreen _defaultScreen;
        [SerializeField] private MenuScreen _waitingScreen;
        [SerializeField] private bool _disallowNoMenus;

        private Stack<MenuScreen> _activeScreens = new Stack<MenuScreen>();

        public static UINavigationManager Instance { get => _instance; }

        private void Awake()
        {
            if (_instance != null && _instance != this) 
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
        }

        private void Start()
        {
            _defaultScreen.Enable();
            _activeScreens.Push(_defaultScreen);
        }

        public void NavigateTo(MenuScreen screen)
        {
            if (screen.ScreenType == ScreenType.PopUpScreen) 
            {
                OpenPopup(screen);
                return;
            }

            OpenFullsizeScreen(screen);
        }

        public void CloseActiveScreen() 
        {
            if (_activeScreens.Count == 1 && _disallowNoMenus)
            {
                MenuSystemDebugger.DebugLogError("Can't close Active Screen. Only " + _activeScreens.Peek() + " is  active", gameObject);
                return;
            }

            _activeScreens.Pop().Disable();
        }

        public void CloseActivePopups() 
        {
            while(_activeScreens.Count > 1) 
            {
                MenuScreen popup = _activeScreens.Pop();

                popup.Disable();
            }
        }

        public void AlternateWaitingScreen(bool setActive) 
        {
            if (setActive) 
            {
                _waitingScreen.Enable();
                return;
            }

            _waitingScreen.Disable();
        }

        private void OpenPopup(MenuScreen screen) 
        {
            _activeScreens.Push(screen);
            screen.Enable();
        }

        private void OpenFullsizeScreen(MenuScreen screen) 
        {
            foreach(MenuScreen activeScreen in _activeScreens) 
            {
                activeScreen.Disable();
            }

            _activeScreens.Clear();

            screen.Enable();
            _activeScreens.Push(screen);
        }

    }

}
