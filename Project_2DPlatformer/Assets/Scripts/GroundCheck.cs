using UnityEngine;

namespace Assets.Scripts
{
    public class GroundCheck : MonoBehaviour
    {

        private Player _player;

        // Use this for initialization
        void Start ()
        {
            _player = GetComponentInParent<Player>();
        }
        void OnCollisionEnter2D(Collision2D col)
        {
            _player.IsGrounded = true;            
        }
    }
}
