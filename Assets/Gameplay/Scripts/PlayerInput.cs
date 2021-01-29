using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [Header("MOVEMENT VALUES")]
    [Tooltip("Velocità del personaggio")]
    [SerializeField] float speed = 10;

    [Tooltip("Velocità angolare del personaggio")]
    [SerializeField] float angVel = 100;

    [Header("PAUSE KEY")]
    [SerializeField] KeyCode pauseKey;

    [Header("PICKUP KEY")]
    public KeyCode PickUpKey;

    Rigidbody rb;
    Inventory inventory;
    public GameObject dialoguePanel;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(PickUpKey) && other.tag == "pickup")
        {
            inventory.PickUp(other.gameObject);
            other.gameObject.SetActive(false);
            UIManager.instance.HidePopUp();
            dialoguePanel.SetActive(true);        
            dialoguePanel.GetComponent<DialogueController>().StartDialogue(other.gameObject);         
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        UIManager.instance.ShowPopUp();
    }

    private void OnTriggerExit(Collider other)
    {
        UIManager.instance.HidePopUp();
    }

    void Movement()
    {
        float forward = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 currentvelocity = transform.forward * speed * forward;
        rb.velocity = currentvelocity * Time.deltaTime;
        transform.Rotate(Vector3.up, angVel * horizontal * Time.deltaTime);
    }
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inventory = GetComponent<Inventory>();
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseKey) && PauseManager.instance.isPause == false)
        {
            PauseManager.instance.GoToPause();
        }

        else
        if (Input.GetKeyDown(pauseKey) && PauseManager.instance.isPause == true)
        {
            PauseManager.instance.ResumeGame();
        }
    }

    void FixedUpdate()
    {
        Movement();
    }
}
