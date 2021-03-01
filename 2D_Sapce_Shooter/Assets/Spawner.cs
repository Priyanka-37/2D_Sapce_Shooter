using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    private Vector3 pos;

    public GameObject spawnObject;
    public Vector3 spawnValue;
    public float waitTime;

    public TextMeshPro scoreText;
    public TextMeshPro restartText;
    public TextMeshPro GameoverText;
    public int scoreValue;
    private int score;
    private bool gameover;
    private bool restart;

    void Start()
    {
        score = 0;
        updateScore();
        GameoverText.text = "";
        restartText.text = "";
        gameover = false;
        restart = false;
        StartCoroutine(spawnWaves());
    }

    [System.Obsolete]
    private void Update()
    {
        if(restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }


    private IEnumerator spawnWaves()
    {
        while(!gameover)
        {
            pos = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), 0.0f, spawnValue.z);

            Instantiate(spawnObject, pos, Quaternion.identity);

            yield return new WaitForSeconds(waitTime);
        }
    }

    public void updateScore()
    {
        score += scoreValue;
        scoreText.text = "Score: " + score;
    }

    public void endGame()
    {
        gameover = true;
        GameoverText.text = "Game Over";
        restart = true;
        restartText.text = "Press R to restart game";
    }
}