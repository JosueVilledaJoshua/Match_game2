using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("SelectCharacters");
        Debug.Log("Play button pushed");
    }

    public void Continue()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Continue button pushed");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit button pushed");
     
    }
}
