using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public string description;
    public Text ItemDesc;
    public Image ItemImage;

    public void PutDesc()
    {
        ItemDesc.text = description;
    }

    public string getDesc()
    {
        return description;
    }
}
