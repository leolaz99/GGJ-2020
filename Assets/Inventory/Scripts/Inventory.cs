using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] items = new GameObject[6];
    [SerializeField] public Text itemDesc;
    string desc;
    public int index = 0;
    public bool control = false;
    PlayerInput playerInput;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(playerInput.PickUpKey) && other.tag=="pickup")
        {
            PickUp(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    void PickUp(GameObject pick)
    {
        items[index] = pick;
        index++;
        control=true;
    }
    
    //public void Descrizione(int index)
    //{
    //    GameObject item = items[index];
    //    desc = item.GetComponent<ItemInfo>().getDesc();
    //    itemDesc.text = desc;
    //}
}
