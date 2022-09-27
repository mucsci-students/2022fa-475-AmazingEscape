using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    private Rigidbody rigidBody;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Rise()
    {
        rigidBody.velocity = new Vector3(0, 1f, 0);
    }

    void Stop()
    {
        rigidBody.velocity = new Vector3(0, 0, 0);
    }

    void Reset()
    {
        rigidBody.position = new Vector3(0, 0, 0);
    }
}
