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
   
    void Update()
    {
        switch (Finder.index)
        {
            case 1:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 30.0f)
                {
                    Finder.control = false;
                }
                break;
            
            case 2:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 60.0f)
                {
                    Finder.control = false;
                }
                break;
            
            case 3:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 90.0f)
                {
                    Finder.control = false;
                }
                break;
            
            case 4:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 120.0f)
                {
                    Finder.control = false;
                }
                break;
            
            case 5:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 150.0f)
                {
                    Finder.control = false;
                }
                break;
            
            case 6:
                if (Finder.control)
                {
                    newangle = new Vector3(Rotation1(), angle.y, angle.z);
                    transform.localEulerAngles = newangle;
                }
                
                if (newangle.x >= 170.0f)
                {
                    Finder.control = false;
                }
                break;
            
            default:
                break;
        }
    }
}