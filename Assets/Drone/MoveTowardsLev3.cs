using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveTowardsLev3 : MonoBehaviour
{

    public GameManager GameManager;
    public Transform Player;
    float MoveSpeed = 2.75f;
    int MinDist = 0;
    int MaxDist = 20;




    void Start()
    {

    }

    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) >= MaxDist)
        {
            return;
        }
            

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
            SceneManager.LoadScene(sceneName: "CityLevel");
        }
    }
}
