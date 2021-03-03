using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject enemyExplosion;
    public GameObject playerExplosion;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            Debug.Log(other.tag);
            return;
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            PlayerPrefs.SetInt("Score", GameManager.instance.scoreManager.score);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

        if(other.tag == "Projectile")
        {
            Instantiate(enemyExplosion, transform.position, transform.rotation);
            GameManager.instance.scoreManager.updateScore();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
