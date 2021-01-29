using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject popUp;
    public static UIManager instance;

    public void ShowPopUp()
    {
        popUp.SetActive(true);
    }

    public void HidePopUp()
    {
        popUp.SetActive(false);
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
