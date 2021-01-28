using UnityEngine;

public class Move : MonoBehaviour
{
    [Tooltip("Velocità del personaggio")]
    [SerializeField] float speed = 10;

    [Tooltip("Velocità angolare del personaggio")]
    [SerializeField] float angvel = 100;

    Rigidbody rb;

    void Movement()
    {
        float forward = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 currentvelocity = transform.forward * speed * forward;
        rb.velocity = currentvelocity * Time.deltaTime;
        transform.Rotate(Vector3.up, angvel * horizontal * Time.deltaTime);
    }
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Movement();
    }
}
