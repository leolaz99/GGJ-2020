using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] items = new GameObject[6];
    public ItemInfo[] itemInfos = new ItemInfo[6]; 
    [SerializeField] public Text itemDesc;
    //string desc;
    public int index = 0;
    public bool control = false;   

    public void PickUp(GameObject pick)
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
