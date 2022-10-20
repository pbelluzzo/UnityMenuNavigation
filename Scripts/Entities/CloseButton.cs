using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PedroBelluzzo.UnityMenuNavigation
{
    [RequireComponent(typeof(Button))]
    public class CloseButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(CloseScreen);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(CloseScreen);
        }

        private void CloseScreen() 
        {
            UINavigationManager.Instance.CloseActiveScreen();
        }
    }

}
