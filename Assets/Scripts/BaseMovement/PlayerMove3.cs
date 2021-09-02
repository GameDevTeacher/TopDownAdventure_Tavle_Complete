using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove3 : MonoBehaviour
{
    public float horizontal = 0f;
    public float vertical = 0f;
    
    public float moveSpeed = 5f;
    
    private void Update()
    {
        horizontal = (Keyboard.current.aKey.isPressed ? -1f : 0f) + (Keyboard.current.dKey.isPressed ? 1f : 0f);
        vertical = (Keyboard.current.sKey.isPressed ? -1f : 0f) + (Keyboard.current.wKey.isPressed ? 1f : 0f);

        transform.position += new Vector3(horizontal * moveSpeed, vertical * moveSpeed, 0f);
    }
}