using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	scoresript SA;


	
	public void Restart()
	{
		SceneManager.LoadScene("New_GamePlay");
		scoresript.scoreValue = 0;
	}

	public void Return()
	{
		SceneManager.LoadScene("Menu 1");

	}
}
