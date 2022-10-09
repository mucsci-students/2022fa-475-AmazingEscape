using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveTowardsLev1 : MonoBehaviour
{

    public GameManager GameManager;
    public Transform Player;
    int MoveSpeed = 4;
    int MinDist = 0;




    void Start()
    {

    }

    void Update()
    {
        if (GameManager.isRunning)
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += Vector3.Scale(transform.forward * MoveSpeed * Time.deltaTime, new Vector3(1.0f, 0.0f, 1.0f));

            }
        }
    }

    void OnTriggerEnter (Collider other)
    {
        GameObject collidedWith = GetComponent<Collider>().gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            SceneManager.LoadScene(sceneName: "Hallway Level");
        }
    }
}
