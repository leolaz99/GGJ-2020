using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] items = new GameObject[6];
    public ItemInfo[] itemInfos = new ItemInfo[6]; 
    [SerializeField] public Text itemDesc;
    //public Text[] itemName = new Text[6];
    //public Sprite[] itemImage = new Sprite[6];
    public int index = 0;
    public bool control = false;   

    public void PickUp(GameObject pick)
    {
        items[index] = pick;
        itemInfos[index] = pick.GetComponent<ItemInfo>();
        index++;
        control=true;
    }
    
    public void Descrizione(int index)
    {
        itemDesc.text = itemInfos[index].description;
        //itemName[index].text = itemInfos[index].Name;
        //itemImage[index] = itemInfos[index].image;
    }
}
