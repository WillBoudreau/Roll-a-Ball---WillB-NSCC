using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parkour1Behaviour : MonoBehaviour
{
    public GameObject button;
    public GameObject player;
    private Transform target;
    private float speed = 15f;
    // Code used is from Unity Documentation "Vector3.MoveTowards" 
    // Start is called before the first frame update
    void Awake()
    {
        transform.position = new Vector3(5.0f, 4.0f, 95.0f);
        target.transform.position = new Vector3(41.0f, 13.0f, 92.0f);
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (button.transform.position == player.transform.position)
        {
            if (Vector3.Distance(transform.position, target.position) < 0.01f)
            {
                transform.position *= -1.0f;
            }
        }
    }
}
