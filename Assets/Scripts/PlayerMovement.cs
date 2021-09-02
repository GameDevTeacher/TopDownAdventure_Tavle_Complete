using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private PlayerInput m_Input;
    private Rigidbody2D m_RigidBody2D;
    
    private void Start()
    {
        m_Input = GetComponent<PlayerInput>();
        m_RigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (m_Input.moveVector.magnitude > 1)
        {
            m_Input.moveVector = m_Input.moveVector.normalized;
        }
        m_RigidBody2D.velocity = m_Input.moveVector * moveSpeed;
    }
}