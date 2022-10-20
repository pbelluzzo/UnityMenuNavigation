using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace PedroBelluzzo.UnityMenuNavigation
{
    public class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private int _sceneIndex;

        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(LoadScene);
        }

        private void LoadScene() 
        {
            SceneManager.LoadScene(_sceneIndex);
        }
    }

}
