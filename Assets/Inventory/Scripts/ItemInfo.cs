using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public string description;
    public Text itemName;
    public Image ItemImage;

    public void PutDesc()
    {
        itemName.text = description;
    }

    public string getDesc()
    {
        return description;
    }
}
