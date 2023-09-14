using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float jump;
    private float speed = 15f;
    private float jumpspeed = 5f;
    public Rigidbody rb;
    public GameObject Tp;
    public GameObject Pickup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInputs()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");
    }
    private void Move()
    {
        rb.AddForce(new Vector3(horizontalInput,jump, verticalInput) * speed);
    }
   
}
