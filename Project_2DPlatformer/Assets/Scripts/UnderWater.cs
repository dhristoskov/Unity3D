using UnityEngine;

namespace Assets.Scripts
{
    public class UnderWater : MonoBehaviour
    {
        void Awake()
        {
            
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.transform.position = new Vector3(-15.6f, -5.08f, 0f);
            }           
        }
    }
}