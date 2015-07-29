using UnityEngine;

namespace Assets.Scripts
{
    public class EnergyBar : MonoBehaviour
    {

        public RectTransform Transform;
        public Player _player;

        // Use this for initialization
        void Start ()
        {
        }
	
        // Update is called once per frame
        void Update ()
        {
            Transform.localScale = new Vector3(_player.EnergyPoints/100f, Transform.localScale.y,Transform.localScale.z);
        }
    }
}