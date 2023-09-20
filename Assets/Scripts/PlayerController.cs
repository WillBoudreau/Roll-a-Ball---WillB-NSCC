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
    public TextMeshProUGUI scoreText;
    public GameObject winTextObject;
    public float gravityScale = 5f;
    //Private Variables
    private float horizontalInput;
    private float verticalInput;
    private float jump;
    private float speed = 15f;
    private int jumpspeed = 5;
    private int score;
    private int pickupCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    void SetCountText()
    {
        scoreText.text = "Score " + score.ToString(); 
        if (score == pickupCount)
        {
            winTextObject.SetActive(true);
        }
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
        //if (jump)
        { 
            //rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        }
       
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score += 100;

            SetCountText();
        }
        if (other.gameObject.CompareTag("Mud"))
        {
            rb.AddForce(Vector3.up * 100);
        }

    }  
     
}
