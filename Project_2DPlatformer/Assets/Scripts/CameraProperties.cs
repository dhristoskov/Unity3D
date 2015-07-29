using UnityEngine;

namespace Assets.Scripts
{
    public class CameraProperties : MonoBehaviour
    {

        private Player _player;
        private Vector2 _velocity;
        public float cameraX = 0.15f;
        public float cameraY = 0.15f;

        public bool isInBoundary;
        public Vector3 maxPosition;
        public Vector3 minPosition;

        // Use this for initialization
        private void Start()
        {
            _player = GetComponentInParent<Player>();
        }

        // Update is called once per frame
        void Update ()
        {
            float positionX = Mathf.SmoothDamp(transform.position.x, _player.transform.position.x,
                ref _velocity.x, cameraX);
            float positionY = Mathf.SmoothDamp(transform.position.y, _player.transform.position.y,
                ref _velocity.y, cameraY);

            transform.position = new Vector3(positionX, positionY, transform.position.z);

            if (isInBoundary)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPosition.x, maxPosition.x),
                    Mathf.Clamp(transform.position.y, minPosition.y, maxPosition.y),
                    Mathf.Clamp(transform.position.z, minPosition.z, maxPosition.z));
            }
        }

        public void SetMinCamPosition()
        {
            minPosition = gameObject.transform.position;
        }

        public void SetMaxCamPosition()
        {
            maxPosition = gameObject.transform.position;
        }
    }
}
