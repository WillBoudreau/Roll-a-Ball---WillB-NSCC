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
    public TextMeshProUGUI remaingText;
    public GameObject winTextObject;
    public float gravityScale = 5f;
    //Private Variables
    private float horizontalInput;
    private float verticalInput;
    private float jump;
    private float speed = 15f;
    private int score;
    private int pickupCount = 10;
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
        remaingText.text = "Remaining Cubes " + pickupCount.ToString();
        scoreText.text = "Score " + score.ToString(); 
        if (score >= 10)
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
    }
    private void Move()
    {
        rb.AddForce(new Vector3(horizontalInput,0f, verticalInput) * speed);
       
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            pickupCount -= 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Mud"))
        {
            rb.AddForce(Vector3.up * -100);
        }

    }  
     
}
