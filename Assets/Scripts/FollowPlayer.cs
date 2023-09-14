using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + player.transform.position;
    }
    void FixedUpdate()
    {
        Move()
    }
    private void ProcessInputs()
    {
        horizontalInput = Input.GetAxis("Horizontal 2");
        verticalInput = verticalInput.GetAxis("Vertical 2");
    }
    private void Move()
    {

    }
}
