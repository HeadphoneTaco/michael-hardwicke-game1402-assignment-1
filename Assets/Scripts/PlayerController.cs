using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpforce = 15f;
    
    [SerializeField] private InputManager inputManager;

    private float _horizontalInput = 0f;
    private Rigidbody2D _playerRb;

    private void Awake()
    {
        _playerRb = GetComponent<Rigidbody2D>(); //get the Rigidbody2D component
    }
    void OnEnable()
    {
        inputManager.OnJump += HandleJumpInput;
        inputManager.OnMove += HandleMoveInput;

    }
    void OnDisable()
    {
        inputManager.OnJump -= HandleJumpInput; //  
        inputManager.OnMove -= HandleMoveInput; //unsubscribe to horizontal movement action
    }
    void HandleJumpInput()
    {
        
    }

    void HandleMoveInput(float value)
    {
        _horizontalInput = value; //store the horizontal input value
    }

    void FixedUpdate()
    {
        HandleMovement(); //handle movement in FixedUpdate for consistent physics updates
    }
    
    void HandleMovement()
    {
        if (_playerRb == null) return;
        
        _playerRb.linearVelocityX = moveSpeed * _horizontalInput; //set the horizontal velocity based on input
        
    }
    
    
}