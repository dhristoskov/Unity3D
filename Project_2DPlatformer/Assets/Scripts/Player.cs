using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {

        private Rigidbody2D _player;
        public bool IsGrounded;
        private float _jumpPower = 420f;
        private Animator _animator;
        public float PlayerSpeed = 4f;

        //Stats points
        private int _energyPoints;
        public int MaxEnergyPoints = 100;
        private int _health;
        public int MaxHealth = 100;


        // Use this for initialization
        void Start ()
        {
            _player = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            Health = MaxHealth;
            EnergyPoints = 0;
        }

        public int Health
        {
            get { return this._health; }
            set
            {
                if (value < 0)
                {
                   PlayerDie();
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                this._health = value;
            }
        }

        public int EnergyPoints
        {
            get { return this._energyPoints; }
            set
            {
                if (value < 0)
                {
                    _energyPoints = 0;
                }
                else if (value > MaxEnergyPoints)
                {
                    _energyPoints = MaxEnergyPoints;
                }
                this._energyPoints = value;
            }
        }
        // Update is called once per frame
        void Update ()
        {
            float move = Input.GetAxis("Horizontal");
            _player.velocity=new Vector2(move*PlayerSpeed,_player.velocity.y);

            if (move < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (move > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            _animator.SetFloat("moveSpeed", Mathf.Abs(move));

            if (Input.GetKey(KeyCode.LeftShift))
            {
                _player.velocity= new Vector2(_player.velocity.x*3 , _player.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
            {
                _player.AddForce(Vector2.up * _jumpPower);
                _animator.SetBool("isGrounded",false);
                IsGrounded = false;

            }else if(IsGrounded)
                _animator.SetBool("isGrounded",true);

            _animator.SetFloat("isFalling", !IsGrounded && _player.velocity.y < 0 ? -1 : 0);
        }
       
        void PlayerDie()
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}