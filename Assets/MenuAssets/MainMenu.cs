using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("MAIN_LEVEL"); // load first scene
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
