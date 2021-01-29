using UnityEngine;

public class GameManager : MonoBehaviour
{
    Inventory inventory;
    
    void WinCondition()
    {

    }

    void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void Update()
    {
        if (inventory.index >= 5)
        {
            WinCondition();
        }
    }
}
