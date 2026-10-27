using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Scene")]
    public string firstSceneName = "Main Game";

    // Hook this function up to the Play UI Button.
    public void LoadScene()
    {
        // TODO: Load the scene stored in firstSceneName.


    }

    // Hook this function up to the Quit UI Button.
    public void QuitGame()
    {
        // Quit the application.
        Application.Quit();
    }
}