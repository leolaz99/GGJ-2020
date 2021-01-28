using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField] public GameObject[] items = new GameObject[6];
    [SerializeField] KeyCode InventoryKey;
    [SerializeField] KeyCode PickUpKey;
    [SerializeField] public bool isInventoryOpen = false;
    [SerializeField] public GameObject inventoryPopup;
    [SerializeField] public Text itemDesc;
    private string desc;
    public int index = 0;
    public bool controll = false;
    // Quando raccolco qualcosa
    void PickUp(GameObject pick)
    {
        items[index] = pick;
        index++;
        controll=true;
    }

    //controllo per aprire l'inventario
    void Update()
    {
        if(Input.GetKeyDown(InventoryKey) && isInventoryOpen == false)
        {
            inventoryPopup.SetActive(true);
            isInventoryOpen = true;
        }
        else 
        if (Input.GetKeyDown(InventoryKey) && isInventoryOpen == true)
        {
            inventoryPopup.SetActive(false);
            isInventoryOpen = false;
        }
         
    }

    //controllo per il pickup
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(PickUpKey) && other.tag=="pickup")
        {
            PickUp(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }


    public void Descrizione(int index)
    {
        GameObject item = items[index];
        desc = item.GetComponent<ItemInfo>().getDesc();
        itemDesc.text = desc;
    }

}
