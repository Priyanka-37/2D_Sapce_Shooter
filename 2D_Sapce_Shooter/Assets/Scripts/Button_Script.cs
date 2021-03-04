using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    public void onButtonClick(int index)
    {
        SceneManager.LoadScene(index);
    }
   
    public void ActiveToTrue(GameObject panel1)
    {
        panel1.SetActive(true);
    }

    public void ActiveToFalse(GameObject panel2)
    {
        panel2.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}


