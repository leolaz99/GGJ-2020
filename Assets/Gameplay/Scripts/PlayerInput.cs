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
    Animator animator;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(PickUpKey) && other.tag == "pickup")
        {
            inventory.PickUp(other.gameObject);
            other.gameObject.SetActive(false);
            UIManager.instance.HidePopUp();
            dialoguePanel.SetActive(true);        
            dialoguePanel.GetComponent<DialogueController>().StartDialogue(other.gameObject);         
        }

        if (Input.GetKeyDown(PickUpKey) && other.tag == "sign" && dialoguePanel.activeInHierarchy == false)
        {
            UIManager.instance.HidePopUp();
            dialoguePanel.SetActive(true);
            dialoguePanel.GetComponent<DialogueController>().StartReading(other.gameObject);
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
        if (dialoguePanel.activeInHierarchy == false)
        {
            float forward = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            animator.SetFloat("Vertical", forward);
            Vector3 currentvelocity = transform.forward * speed * forward;
            rb.velocity = currentvelocity * Time.deltaTime;
            transform.Rotate(Vector3.up, angVel * horizontal * Time.deltaTime);
        }
        else
        {
            Vector3 currentvelocity = transform.forward * speed * 0;
            rb.velocity = currentvelocity * Time.deltaTime;
            animator.SetFloat("Vertical", 0);
        }
        
    }
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inventory = GetComponent<Inventory>();
        animator = GetComponentInChildren<Animator>();
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
