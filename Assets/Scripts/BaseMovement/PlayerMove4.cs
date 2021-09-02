using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove4 : MonoBehaviour
{
    private Vector2 _moveVector;
    public float moveSpeed;
    
    private void Update()
    {
        _moveVector.x = (Keyboard.current.aKey.isPressed ? -1f : 0f) + (Keyboard.current.dKey.isPressed ? 1f : 0f);
        _moveVector.y = (Keyboard.current.sKey.isPressed ? -1f : 0f) + (Keyboard.current.wKey.isPressed ? 1f : 0f);

        transform.Translate(_moveVector * moveSpeed * Time.deltaTime);
    }
}