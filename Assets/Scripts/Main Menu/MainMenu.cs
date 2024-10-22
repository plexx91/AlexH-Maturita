using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Menu;

    public void StartGame()
    {
        SceneManager.LoadScene(Menu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
