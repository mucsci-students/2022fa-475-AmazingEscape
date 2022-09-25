using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private Rigidbody waterBody;
    // Start is called before the first frame update
    void Start()
    {
        waterBody = GetComponent<Rigidbody>();
        waterBody.velocity = new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
