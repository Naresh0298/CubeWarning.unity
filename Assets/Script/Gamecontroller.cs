using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gamecontroller : MonoBehaviour
{

	public GameObject[] hazard;
	public Vector3 spawnValuesmin, spawnValuesmax;
	public Vector3 spawnValuesmin_1, spawnValuesmax_1;
	public Vector3 spawnValuesmin_2, spawnValuesmax_2;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public bool Spawn;
	int i;


	public float secPause_1 = 0.0f;
	public float secPause_2 = 0.0f;
	public float secPause_3 = 0.0f;

	int randEnemy;

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

for (i = 0; i < hazardCount / 3;)

{
	if (Spawn)
	{
		if (secPause_1 > 0.0f)
		{
			yield return new WaitForSeconds(secPause_1);
			secPause_1 = 0.0f;
		}
		//randEnemy = Random.Range(0, 2);

		i++;
		Vector3 spawnPosition = new Vector3(Random.Range(spawnValuesmin.x, spawnValuesmax.x), Random.Range(spawnValuesmin.y, spawnValuesmax.y), spawnValuesmin.z);

		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(hazard[0], spawnPosition, spawnRotation);


	}
	else
	{
		secPause_1 += spawnWait;
	}
	yield return new WaitForSeconds(spawnWait);
}


for (i = hazardCount / 3; i < (2 * hazardCount) / 3;)

{
	if (Spawn)
	{
		if (secPause_2 > 0.0f)
		{
			yield return new WaitForSeconds(secPause_2);
			secPause_2 = 0.0f;
		}
		//randEnemy = Random.Range(0, 2);

		i++;

		Vector3 spawnPosition_1 = new Vector3(Random.Range(spawnValuesmin_1.x, spawnValuesmax_1.x), spawnValuesmin_1.y, spawnValuesmin_1.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(hazard[1], spawnPosition_1, spawnRotation);


	}
	else
	{
		secPause_2 += spawnWait;
	}
	yield return new WaitForSeconds(spawnWait);
}


			for (i = (2 * hazardCount) / 3; i < hazardCount;)

			{
				if (Spawn)
				{
					if (secPause_3 > 0.0f)
					{
						yield return new WaitForSeconds(secPause_3);
						secPause_3 = 0.0f;
					}
					//randEnemy = Random.Range(0, 2);

					i++;

		               Vector3 spawnPosition_2 = new Vector3(spawnValuesmin_2.x,Random.Range(spawnValuesmax_2.y, spawnValuesmin_2.y), spawnValuesmin_2.z);
					Quaternion spawnRotation = Quaternion.identity;
					Instantiate(hazard[2], spawnPosition_2, spawnRotation);


				}
				else
				{
					secPause_3 += spawnWait;
				}
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
			//yield return new WaitForSeconds(waveWait);
		}

	}


