using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Destination : MonoBehaviour

{
    public NavMeshAgent playerAgent;
    public Vector3 target;
    public float x;
    public float z;
    
    //public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();

        x = Random.Range(-3f, 8f);
        z = Random.Range(-13f, 19f);
        playerAgent.SetDestination(new Vector3(x,0.8f,z));
        target = new Vector3(x, 0.8f, z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance( target, transform.position)<2){
            x = Random.Range(-3f, 8f);
            z = Random.Range(-13f, 19f);
            playerAgent.SetDestination(new Vector3(x, 0.8f, z));
            target = new Vector3(x, 0.8f, z);
        }

    }
}
