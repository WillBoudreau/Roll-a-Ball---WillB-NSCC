using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parkour1Behaviour : MonoBehaviour
{
    public GameObject button;
    public GameObject player;
    public GameObject stop;
    public GameObject parkour;
    private float risespeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button.transform.position == player.transform.position)
        {
            Transform.position.y = stop;
        }
    }
}
