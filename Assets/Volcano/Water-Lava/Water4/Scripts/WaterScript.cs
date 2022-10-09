using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{

    public GameManager gameManager;
    private Rigidbody waterBody;
    private bool set = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isRunning && !set)
        {
            waterBody = GetComponent<Rigidbody>();
            waterBody.velocity = new Vector3(0, 0.5f, 0);
            set = true;
        }
    }
}
