using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

	scoresript SA;

	public static bool gameover = true;

    	//public void Update()
    	//{
    	//	if (Input.GetKeyDown(KeyCode.Escape))
    	//	{
    	//		if (gameover)
    	//		{

    	//			Greturn();
    	//		}
    	//	}
    	//}


	public void Grestart()
	{
		SceneManager.LoadScene("New_GamePlay");
		scoresript.scoreValue = 0;
	}

	public void Greturn()
	{
		SceneManager.LoadScene("Menu 1");
	}
}
