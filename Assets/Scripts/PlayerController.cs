using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public Rigidbody rb;
    public GameObject Tp;
    public GameObject Pickup;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI cubeText;
    public GameObject winTextObject;
    //Private Variables
    private float horizontalInput;
    private float verticalInput;
    private float jump;
    private float speed = 15f;
    private float jumpspeed = 5f;
    private int score;
    private int pickupCount = 5;
    private int cubeCollect;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
        Console.ReadKey();
        score = 0;
        cubeCollect = 0;
        
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
        scoreText.text = "Cube collected: " + cubeCollect.ToString();
        scoreText.text = "Score: " + score.ToString(); 
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
     private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Mud")
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10);
        }
    }
}
