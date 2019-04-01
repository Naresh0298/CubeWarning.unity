using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenLoader : MonoBehaviour {

	public GameObject loadingScene;
	public Slider slider;

	public Text Menuscore;

	private void Start()
	{
		Menuscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("qiut");
        }
	}


	public void LoadLevel (int sceneIndex)
    
	{
		StartCoroutine(LoadAsynchronously(sceneIndex));
		scoresript.scoreValue = 0;
	}

	IEnumerator LoadAsynchronously (int sceneindex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
		loadingScene.SetActive(true);

		while(!operation.isDone)
		{
			float progress = Mathf.Clamp01(operation.progress / .9f);

			slider.value = progress;

			yield return null;
		}

	}
	public void EndGame()
    {
		
			Application.Quit();
			Debug.Log("qiut");

    }

	public void Reset()
    {
        PlayerPrefs.DeleteAll();
        Menuscore.text = "0";


    }
}
