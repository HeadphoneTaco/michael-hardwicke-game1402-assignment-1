using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public void SetMoveInput(Vector2 input)
    {
         /* implement */
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump");
    }
}