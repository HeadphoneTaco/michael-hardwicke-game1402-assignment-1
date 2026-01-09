using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInputActions _testActions;

        void Awake()
        {
            _testActions = new PlayerInputActions(); //we created an object of the class PlayerInputActions
            _testActions.Enable(); //we turn it on to listen to key inputs
        }

        void OnEnable()
        {
            _testActions.Player.Jump.performed += Jump;
        }

        void OnDisable()
        {
            _testActions.Player.Jump.performed -= Jump;
        }

        void Jump(InputAction.CallbackContext ctx)
        {
            Debug.Log("Jump");
        }
    }