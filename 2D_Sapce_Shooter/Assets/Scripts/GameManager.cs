using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public ScoreManager scoreManager;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            StartCoroutine(nextScene());
        }
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
