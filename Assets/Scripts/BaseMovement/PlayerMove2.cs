using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2 : MonoBehaviour
{
    public float horizontal = 0f;
    public float vertical = 0f;

    public float moveSpeed = 5f;
   
    // ? is the Conditional Operator
    private void Update()
    {
        float left = Keyboard.current.aKey.isPressed ? -1f : 0f;
        float right = Keyboard.current.dKey.isPressed ? 1f : 0f;

        float up = Keyboard.current.wKey.isPressed ? 1f : 0f;
        float down = Keyboard.current.sKey.isPressed ? -1f : 0f;
        
        horizontal = left + right;
        vertical = down + up;

        transform.position += new Vector3(horizontal * moveSpeed, 
            vertical * moveSpeed, 0f) * Time.deltaTime;
    }
}