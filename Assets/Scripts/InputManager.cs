using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   // private PlayerController _playerController;

    private PlayerInputActions _inputActions;

    private void Awake()
    {
        _inputActions = new PlayerInputActions(); //create an object of the class PlayerInputActions
    }

    private void OnEnable()
    {
        _inputActions.Player.Enable(); //Activate PlayerInputActions object to listen to key inputs
       // _inputActions.Player.Move.performed += OnMove;
       // _inputActions.Player.Move.canceled += OnMoveCanceled;
        _inputActions.Player.Jump.performed += OnJump;
    }

    private void OnDisable()
    {
       // _inputActions.Player.Move.performed -= OnMove;
       // _inputActions.Player.Move.canceled -= OnMoveCanceled;
        _inputActions.Player.Jump.performed -= OnJump;
        _inputActions.Player.Disable(); //Deactivate PlayerInputActions object to stop listening to key inputs
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
     //   _playerController.SetMoveInput(input); //Log move input for debugging
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
      //  _playerController.SetMoveInput(Vector2.zero);
        Debug.Log("Canceled"); //Log cancel movement action for debugging
    }

    private void OnJump(InputAction.CallbackContext context)
    {
       // _playerController.Jump();
        Debug.Log("Jump"); //Log jump action for debugging
    }
}