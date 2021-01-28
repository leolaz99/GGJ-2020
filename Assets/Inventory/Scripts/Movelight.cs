using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movelight : MonoBehaviour
{
    Inventory Finder;
    Vector3 angle;
    Vector3 newangle;
    [Tooltip("velocità con cui si muove il sole")]
    [SerializeField] float speed = 10f;
    float rotation = 10f;
    public bool direction = true;
    float Rotation1()
    {
        rotation += speed * Time.deltaTime;
        return rotation;
    }
    private void Awake()
    {
        Finder = FindObjectOfType<Inventory>();
        angle = transform.localEulerAngles;
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        switch (Finder.index)
        {
            case 1:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 30.0f)
                {
                    Finder.controll = false;
                }
                break;
            case 2:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 60.0f)
                {
                    Finder.controll = false;
                }
                break;
            case 3:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 90.0f)
                {
                    Finder.controll = false;
                }
                break;
            case 4:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 120.0f)
                {
                    Finder.controll = false;
                }
                break;
            case 5:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 150.0f)
                {
                    Finder.controll = false;
                }
                break;
            case 6:
                if (Finder.controll)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                if (newangle.x >= 180.0f)
                {
                    Finder.controll = false;
                }
                break;
            default:
                break;
        }
    }
}