using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject enemyExplosion;
    public GameObject playerExplosion;
    private Spawner spawner;

    private void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Spawner");
        if(temp != null)
        {
            spawner = temp.GetComponent<Spawner>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundry")
        {
            return;
        }

        Instantiate(enemyExplosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            spawner.endGame();
        }
        Destroy(this.gameObject);
        Destroy(other.gameObject);
        spawner.updateScore();
    }
}
