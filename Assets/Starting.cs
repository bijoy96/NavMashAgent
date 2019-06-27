using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab,new Vector3(-1 , .8f, 2),Quaternion.identity);
        Instantiate(prefab, new Vector3(1, .8f, 18), Quaternion.identity);
        Instantiate(prefab, new Vector3(6, .8f, 16), Quaternion.identity);
        Instantiate(prefab, new Vector3(6, .8f, -3), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
