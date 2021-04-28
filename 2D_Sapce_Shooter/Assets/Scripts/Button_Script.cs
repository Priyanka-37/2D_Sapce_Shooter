using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    public void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
   
    public void setActiveTrue(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void SetActiveFalse(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}


