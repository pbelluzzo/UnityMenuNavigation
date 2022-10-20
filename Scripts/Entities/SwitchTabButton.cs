using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PedroBelluzzo.UnityMenuNavigation
{
    [RequireComponent(typeof(Button))]

    public class SwitchTabButton : MonoBehaviour
    {
        [SerializeField] private TabWindowController _tabController;
        [SerializeField] private TextMeshProUGUI _buttonText;
        [SerializeField] private GameObject _activeMarker;
        [SerializeField] private int _tabIndex = 0;
        [SerializeField] private TabButonConfigs _configs;

        private Button _button;

        public GameObject ActiveMarker { get => _activeMarker; }
        public int TabIndex { get => _tabIndex; }

        private void Awake()
        {
            _button = GetComponent<Button>();
            SetActive(false);
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(ChangeTab);
        }
        private void OnDisable()
        {
            _button.onClick.RemoveListener(ChangeTab);
        }

        private void ChangeTab() 
        {
            _tabController.ChangeActiveTab(this);
        }

        public void SetActive(bool state) 
        {
            _activeMarker.SetActive(state);
            _buttonText.color = state ? _configs.ActiveTextColor : _configs.InactiveTextColor;
        }
    }

}
