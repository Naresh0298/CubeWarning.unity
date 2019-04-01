using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

	public static bool GamePaused = false;   
	public GameObject PauseUI;


	public void Update()

	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GamePaused)
			{

				Resume();
			}
			else
			{
				Pause();
			}
		}

	}


	public void Resume()
	{
		
		PauseUI.SetActive(false);
		Time.timeScale = 1f;
		GamePaused = false;
	}

	public void Pause()
	{
		PauseUI.SetActive(true);
		Time.timeScale = 0f;
		GamePaused = true;
	}

	public void Loadmenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu 1");
		
	}
 
}
