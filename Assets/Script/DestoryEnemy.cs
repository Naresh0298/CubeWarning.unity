using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryEnemy : MonoBehaviour
{
	public GameObject playerExplosion;
	public MeshRenderer msh;
	public GameObject BD;

	Transform flareone;
	public static bool Gameover = false;
	public GameObject GameOver;

	private void Start()
	{
		msh = GetComponent<MeshRenderer>();

        flareone = GameObject.FindGameObjectWithTag("backfire").transform;
	}

	public void Update()
	{
		if(msh.enabled==false)
		{
			{
				Debug.Log("over");
				GOver();
			}
			
		}

	}
    
	private void OnTriggerEnter(Collider other)
	{

		Instantiate(playerExplosion, transform.position, transform.rotation);

		msh.enabled = false;
	}

    public void GOver()
	{
		GameOver.SetActive(true);
		flareone.gameObject.SetActive(false);
		playerExplosion.SetActive(false);

		BD.SetActive(false);
	}	
}