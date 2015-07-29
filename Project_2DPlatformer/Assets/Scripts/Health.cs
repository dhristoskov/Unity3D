using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        private Player _player;
        public Image _image;

        // Use this for initialization
        void Start ()
        {
            _image = GetComponent<Image>();
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            _image.fillAmount = _player.Health / 100f;
        }
    }
}
