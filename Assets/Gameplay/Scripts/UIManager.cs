using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject popUp;
    [SerializeField] Text score;
    public static UIManager instance;
    Inventory inventory;

    public void ShowPopUp()
    {
        popUp.SetActive(true);
    }

    public void HidePopUp()
    {
        popUp.SetActive(false);
    }

    public void ShowScore()
    {
        score.text = "MEMORIES\n" + inventory.index + "/6";
    }

    void Awake()
    {
        if (instance == null)
            instance = this;

        inventory = FindObjectOfType<Inventory>();
    }

    void Update()
    {
        ShowScore();
    }
}
