using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryScreen;
    [SerializeField] GameObject AudioScreen;
    [SerializeField] GameObject controlsScreen;
    [SerializeField] GameObject pauseScreen;
    [SerializeField] GameObject player;
    [SerializeField] Inventory inventory;

    [HideInInspector] public bool isPause = false;
    
    public static PauseManager instance;

    public void GoToPause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        isPause = true;
        GetPick();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void GoToInventory()
    {
        inventoryScreen.SetActive(true);
        AudioScreen.SetActive(false);
        controlsScreen.SetActive(false);
        GetPick();
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

    public void GetPick()
    {
        player = GameObject.Find("Player");
        inventory = player.GetComponent<Inventory>();
        for (int i = 0; i < inventory.itemInfos.Length; i++)
        {
            if (inventory.itemInfos[i] != null)
            {
                GameObject.Find("ItemText (" + i + ")").GetComponent<Text>().text = inventory.itemInfos[i].Name;
                GameObject.Find("ItemImage (" + i + ")").GetComponent<Image>().sprite = inventory.itemInfos[i].image;
            }
        }     
    }

  
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
