using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
