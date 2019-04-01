using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoresript : MonoBehaviour
{

	public static int scoreValue = 0;
   
	Text score;

	public Text Pscore;

	public Text Bestscore;

	public Text Escore;
    
	void Start()
	{
        
		score = GetComponent<Text>();



		Bestscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
	}

    
    
	void Update()
	{ 
		
		score.text = " " + scoreValue;


		int num = scoresript.scoreValue;
        score.text = num.ToString();

		Pscore.text = PlayerPrefs.GetInt("Pscore", 0).ToString();
		PlayerPrefs.SetInt("Pscore", num);

		Escore.text = PlayerPrefs.GetInt("Escore", 0).ToString();
        PlayerPrefs.SetInt("Escore", num);


		if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
		{
			PlayerPrefs.SetInt("HighScore", scoreValue);
		}         
	}



}
