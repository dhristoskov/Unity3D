using UnityEngine;

namespace Assets.Scripts
{
    public class Bonus : MonoBehaviour
    {

        public float Speed = 30.0f;
        private Vector3 _point;
        public bool IsMoving;
        private Player _player;
        public AudioSource Audio;

        // Use this for initialization
        void Start ()
        {
            _point = transform.position + Vector3.one;
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            Audio = GetComponent<AudioSource>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            if (IsMoving)
            {
                transform.RotateAround(_point, new Vector3(0, 0, 1), Speed * Time.deltaTime);
            }           
        }

        void OnTriggerEnter2D(Collider2D colision)
        {
            if (colision.gameObject.tag != "Player")
            {
                return;
            }
            Audio.Play();
            _player.EnergyPoints += 5;            
            Destroy(gameObject);           
        }
    }
}
