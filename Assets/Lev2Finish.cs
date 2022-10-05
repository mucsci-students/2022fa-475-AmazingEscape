using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lev2Finish : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager;

	// When an object enters the finish zone, let the
	// game manager know that the current game has ended
	void OnTriggerEnter(Collider other)
	{
		gameManager.RestartLev2();
	}
}

