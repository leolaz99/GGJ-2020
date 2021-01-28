using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject startingScreen;
    public GameObject settings;
    public GameObject audioSettings;
    public GameObject controlsSettings;
    public GameObject credits;

    public void GoToGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void GoToStartingScreen()
    {
        startingScreen.SetActive(true);
        settings.SetActive(false);
    }

    public void GoToAudioSettings()
    {
        settings.SetActive(true);
        audioSettings.SetActive(true);
        startingScreen.SetActive(false);
        controlsSettings.SetActive(false);
    }

    public void GoToControlsSettings()
    {   
        controlsSettings.SetActive(true);
        audioSettings.SetActive(false);
    }

    public void GoToCredits()
    {
        credits.SetActive(true);
        startingScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
