using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    private PlayerController _playerController;
    private PlayerInputActions _inputActions;
    public  UnityAction<int> _openDoor;
    private List<int> _collectedKeys = new List<int>();

    private void Awake()
    {
    
        _playerController = GetComponent<PlayerController>(); //Get reference to PlayerController component
        _inputActions = new PlayerInputActions(); //create an object of the class PlayerInputActions
    }

    private void OnEnable()
    {
        _inputActions.Player.Enable(); //Activate PlayerInputActions object to listen to key inputs
        _inputActions.Player.Move.performed += OnMove;
        _inputActions.Player.Move.canceled += OnMoveCanceled;
        _inputActions.Player.Jump.performed += OnJump;
        _openDoor += OnOpenDoor;
    }

    private void Start()
    {
        _openDoor?.Invoke(1); //Example of invoking the open door action with door number 1
    }

    private void OnDisable()
    {
        _inputActions.Player.Move.performed -= OnMove;
        _inputActions.Player.Move.canceled -= OnMoveCanceled;
        _inputActions.Player.Jump.performed -= OnJump;
        _inputActions.Player.Disable(); //Deactivate PlayerInputActions object to stop listening to key inputs
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        _playerController.SetMoveInput(input); //Log move input for debugging
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        _playerController.SetMoveInput(Vector2.zero);
        Debug.Log("Canceled"); //Log cancel movement action for debugging
    }

    public void OnOpenDoor(int doorNumber)
    {
        Debug.Log("Door Opened " + doorNumber); //Log door open action for debugging
    }
    private void OnJump(InputAction.CallbackContext context)
    {
        _playerController.Jump();
        Debug.Log("Jump"); //Log jump action for debugging
    }
}