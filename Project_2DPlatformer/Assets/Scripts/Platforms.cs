using UnityEngine;

namespace Assets.Scripts
{
    public class Platforms : MonoBehaviour
    {

        public Vector2 Direction = Vector2.up;
        public float Speed = 1.8f;

        // Use this for initialization
        void Start ()
        {
	
        }
	
        // Update is called once per frame
        void Update ()
        {
            transform.Translate(Direction * Speed * Time.deltaTime);

            if (transform.position.y > 3.00f)
            {
                Vector2 position = transform.position;
                position.y = 3.00f;
                transform.position = position;
                Direction = Vector2.down;
            }

            if (transform.position.y < -1.2f)
            {
                Vector2 position = transform.position;
                position.y = -1.2f;
                transform.position = position;
                Direction = Vector2.up;
            }
        }
    }
}
