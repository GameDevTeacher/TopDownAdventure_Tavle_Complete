using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove1 : MonoBehaviour
{
    public float moveSpeed = 3f;
    
    private void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Move(Vector3.up);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            Move(Vector3.down);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Move(Vector3.left);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            Move(Vector3.right);
        }
    }
    
    private void Move(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}