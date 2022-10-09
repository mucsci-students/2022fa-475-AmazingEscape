using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveTowardsLev2 : MonoBehaviour
{

    public GameManager GameManager;
    public Transform Player;
    int MoveSpeed = 7;
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
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject collidedWith = GetComponent<Collider>().gameObject;
        Debug.Log(other.tag);
        if (other.tag.Equals("Player"))
        {
            SceneManager.LoadScene(sceneName: "VolcanoLevel");
        }
    }
}
