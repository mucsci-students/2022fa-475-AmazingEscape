using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject canvas;
    public GameObject mainMenu;
    public GameObject backgroundImg;
    public GameObject eventSystems;

    public void loadScene()
    {
        //DontDestroyOnLoad (canvas);
        //DontDestroyOnLoad (eventSystems);
        SceneManager.LoadScene(sceneName: "Hallway Level");
        mainMenu.SetActive(false);
        backgroundImg.SetActive(false);
    }
}
