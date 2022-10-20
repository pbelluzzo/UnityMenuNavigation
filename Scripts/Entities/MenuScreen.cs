using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PedroBelluzzo.UnityMenuNavigation
{
    public class MenuScreen : MonoBehaviour
    {
        [SerializeField] protected GameObject _screenGameObject;

        [SerializeField] protected ScreenType _screenType;
        public ScreenType ScreenType { get => _screenType; }

        private void Awake()
        {
            Disable();    
        }

        public virtual void Enable() 
        {
            _screenGameObject.SetActive(true);
            EnableEventListening();
        }

        public virtual void Disable() 
        {
            _screenGameObject.SetActive(false);
            DisableEventListening();
        }

        protected virtual void EnableEventListening() { }
        protected virtual void DisableEventListening() { }
    }

    public enum ScreenType 
    {
        FullScreen,
        PopUpScreen
    }

}
