using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_02 : MonoBehaviour {


    
    public GameObject hazard2;
    public Vector3 spawnValuesmin, spawnValuesmax;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public bool Spawn;

    public float secPause = 0.0f;

    void Start()
    {
        StartSpawn();

        if (Spawn)
            StartCoroutine(SpawnWaves());
    }

    public void StartSpawn()
    {
        Spawn = true;
    }
    public void EndSpawn()
    {
        Spawn = false;

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount;)
            {
                if (Spawn)
                {
                    if (secPause > 0.0f)
                    {
                        yield return new WaitForSeconds(secPause);
                        secPause = 0.0f;
                    }

                    i++;
                    Vector3 spawnPosition = new Vector3(Random.Range(spawnValuesmin.x, spawnValuesmax.x), Random.Range(spawnValuesmin.y, spawnValuesmax.y), spawnValuesmin.z);
                    //Vector3 spawnPosition = new Vector3(Random.Range(spawnValuesmin.x, spawnValuesmax.x), spawnValuesmin.y, spawnValuesmin.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    Instantiate(hazard2, spawnPosition, spawnRotation);
                }
                else
                {
                    secPause += spawnWait;
                }
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}