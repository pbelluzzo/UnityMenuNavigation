using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PedroBelluzzo.UnityMenuNavigation
{
    public class TabWindowController : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _windowTabs = new List<GameObject>();
        [SerializeField] private SwitchTabButton _defaultActiveButton = default;

        private int _curActiveTab = 0;
        private SwitchTabButton _currentActiveButton;

        private void Start()
        {
            if (_windowTabs.Count == 0) 
            {
                MenuSystemDebugger.DebugLog("No tabs were defined for this Tab Controller.", gameObject);
                return;
            }

            foreach (GameObject tab in _windowTabs) 
            {
                tab.SetActive(false);
            }

            ChangeActiveTab(_defaultActiveButton);
        }



        public void ChangeActiveTab(SwitchTabButton button)
        {
            if (_currentActiveButton != null) 
            {
                _currentActiveButton.SetActive(false);
            }

            foreach(GameObject tab in _windowTabs) 
            {
                tab.SetActive(false);
            }

            _windowTabs[button.TabIndex].SetActive(true);
            button.SetActive(true);
            _currentActiveButton = button;
        }
    }

}
