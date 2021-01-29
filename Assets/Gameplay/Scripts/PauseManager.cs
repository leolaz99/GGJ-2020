using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryScreen;
    [SerializeField] GameObject AudioScreen;
    [SerializeField] GameObject controlsScreen;
    [SerializeField] GameObject pauseScreen;

    [HideInInspector] public bool isPause = false;
    
    public static PauseManager instance;

    public void GoToPause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        isPause = true;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToInventory()
    {
        inventoryScreen.SetActive(true);
        AudioScreen.SetActive(false);
        controlsScreen.SetActive(false);       
    }

    public void GoToAudioSettings()
    {
        AudioScreen.SetActive(true);
        inventoryScreen.SetActive(false);
        controlsScreen.SetActive(false);
    }

    public void GoToControlsSetings()
    {
        controlsScreen.SetActive(true);
        inventoryScreen.SetActive(false);
        AudioScreen.SetActive(false);
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

    public void Get1Pick()
    {
    }

    public void Get2Pick()
    {
    }

    public void Get3Pick()
    {
    }

    public void Get4Pick()
    {
    }

    public void Get5Pick()
    {
    }

    public void Get6Pick()
    {    
    }
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
