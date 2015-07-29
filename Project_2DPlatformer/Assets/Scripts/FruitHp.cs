using UnityEngine;

namespace Assets.Scripts
{
    public class FruitHp : MonoBehaviour
    {

        private Animator _animator;
        private Player _player;

        // Use this for initialization
        void Start ()
        {
            _animator = GetComponent<Animator>();
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            _animator.SetTrigger("Glow");
        }
        void OnTriggerEnter2D(Collider2D colision)
        {
            if (colision.gameObject.tag != "Player")
            {
                return;
            }
            _player.Health += 10;
            Destroy(gameObject);
        }
    }
}
