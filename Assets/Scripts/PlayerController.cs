using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public Rigidbody rb;
    public GameObject Tp;
    public GameObject Pickup;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    //Private Variables
    private float horizontalInput;
    private float verticalInput;
    private float jump;
    private float speed = 15f;
    private float jumpspeed = 5f;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winTextObject.SetActive(false);
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    void SetCountText()
    {
        countText.text = "Count " + count.ToString(); 
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
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score += 100;

            SetCountText();
        }
        
    }  
}
