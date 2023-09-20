using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         void OnTriggerStay(Collider other)
        {
            if(other.tag == "Mud")
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
            }
        }
    }
}
