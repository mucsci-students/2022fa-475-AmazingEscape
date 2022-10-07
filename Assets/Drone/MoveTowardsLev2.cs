using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveTowardsLev2 : MonoBehaviour
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
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject collidedWith = GetComponent<Collider>().gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            SceneManager.LoadScene(sceneName: "VolcanoLevel");
        }
    }
}
