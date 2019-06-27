using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public KeyCode pressUp;
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0) {
            GetComponent<Transform>().position = new Vector3(transform.position.x, 2, transform.position.z);
        }
        if (Input.GetAxis("Vertical") == 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }
}
