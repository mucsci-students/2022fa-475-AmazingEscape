using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void openMainMenu()
    {
        SceneManager.LoadScene(sceneName: "IntroMenu");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
