using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class PauseMenu : MonoBehaviour
    {
        public GameObject PauseUi;
        private bool _onPause = false;

        // Use this for initialization
        void Start ()
        {
            PauseUi.SetActive(false);
        }
	
        // Update is called once per frame
        void Update ()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _onPause = !_onPause;
            }

            if (_onPause)
            {
                PauseUi.SetActive(true);
                Time.timeScale = 0.01f;
            }

            if (!_onPause)
            {
                PauseUi.SetActive(false);
                Time.timeScale = 1;
            }
        }

        public void OnResume()
        {
            _onPause = false;
        }

        public void OnRestart()
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        public void OnQuit()
        {
            Application.Quit();
        }
    }
}
