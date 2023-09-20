using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private float horizontalInput;
    private  float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        horizontalInput = Input.GetAxis("Horizontal 2");
        verticalInput = Input.GetAxis("Vertical 2");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + player.transform.position;
    }
}
