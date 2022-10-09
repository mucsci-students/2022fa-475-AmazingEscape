using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public void openMainMenu()
    {
        SceneManager.LoadScene(sceneName: "IntroMenu");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
