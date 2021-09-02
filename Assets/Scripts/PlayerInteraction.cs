using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float score = 0f;
    
    [Space(5)]
    public string mainMenu;
    public string winScreen;
    public bool canInteract;
    
    [Space(5)]
    [Header("Timer")]
    public float timerValue;
    private float m_Timer;
    
    [Space(5)]
    [Header("Components")]
    public SceneController sceneController;
    private PlayerInput m_Input;
    
    private void Start()
    {
        m_Timer = timerValue;
        m_Input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        // All of the code that initialises the timer and changes the scene
        TimerSceneChange();
        
        // If we have 9 coins & we have touched the Portal & we clicked the Interact key
        if (canInteract && m_Input.interact)
        {
            // Change the scene
            sceneController.LoadScene(winScreen);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // A function that deals with the Coin Collision -> Check Below
        CoinCollision(other);

        // A function that deals with the portal collision -> Check Below
        PortalCollision(other);
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Portal"))
        {
            canInteract = false;
        }
    }

    private void CoinCollision(Collider2D other)
    {
        if (!other.CompareTag("Coin")) return;
        score++;
        Destroy(other.gameObject);
    }

    private void PortalCollision(Collider2D other)
    {
        if (!other.CompareTag("Portal")) return;
        
        if (score >= 9)
        {
            canInteract = true;
            print("Press F to Enter");
        }
        else
        {
            print("You need more Coins!");
        }
    }

    private void TimerSceneChange()
    {
        if (m_Timer > 0)
        {
            m_Timer -= 1f * Time.deltaTime;
        }
        else
        {
            sceneController.LoadScene(mainMenu);
        }
    }
}