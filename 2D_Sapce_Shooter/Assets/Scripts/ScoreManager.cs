using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshPro scoreText;
    public int score;

    private void Awake()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void updateScore()
    {
        ++score;
        scoreText.text = "Score: " + score;
    }
}
