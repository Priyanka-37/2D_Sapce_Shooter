using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObject;
    public Vector3 spawnValue;
    public float waitTime;

    void Start()
    {
        StartCoroutine(spawnWaves());
    }

    private IEnumerator spawnWaves()
    {
        while(true)
        {
            Vector3 pos = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, 0f);

            Instantiate(spawnObject, pos, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}