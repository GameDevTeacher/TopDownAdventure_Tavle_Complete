using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // This Function takes the parameter of a String and loads the scene with the name of the string
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    // This function quits the application (the game)
    // It also quits out of Playmode in the Unity Editor
    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}