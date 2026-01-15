using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float _maxSpeed = 8f;

    private Rigidbody2D _rigidBody;
    private Vector2 _moveInput;
    

        void Awake()
        {
             _rigidBody = GetComponent<Rigidbody2D>();
        }
        
        public void Jump()
        {
            
        }
        
        public void SetMoveInput(Vector2 input)
        {
            _moveInput = input;
        }
        private void FixedUpdate()
        {
            float _moveForce = Mathf.Clamp(_maxSpeed - Mathf.Abs(_rigidBody.linearVelocity.x), 0f, _maxSpeed);
            Vector2 force = new Vector2(_moveInput.x * _moveForce, 0f);
            _rigidBody.AddForce(force);
        }
     //this code is left as an exercise for the reader  
       
    }