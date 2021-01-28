using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("MOVEMENT VALUES")]
    [Tooltip("Velocità del personaggio")]
    [SerializeField] float speed = 10;

    [Tooltip("Velocità angolare del personaggio")]
    [SerializeField] float angVel = 100;

    [Header("PAUSE KEY")]
    [SerializeField] KeyCode pauseKey;
    
    Rigidbody rb;


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
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseKey) && PauseManager.instance.isPause == false)
        {
            PauseManager.instance.PauseGame();
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
