using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    [HideInInspector] public bool isPause = false;
     public static PauseManager instance;

    public void PauseGame()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        isPause = true;
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
