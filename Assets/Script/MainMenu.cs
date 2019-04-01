using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	 void Awake()
	{
		PlayGame();
	}
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void EndGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
   
}